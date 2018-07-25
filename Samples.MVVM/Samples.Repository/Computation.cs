using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.Repository
{
    public class Computation : IComputation
    {
        CancellationTokenSource tokenSource;
        Progress<int> progress;

        public Computation()
        {
            this.IsExectuting = false;
        }

        public string Name { get { return "Actual "; } }

        public bool IsExectuting { get; protected set; }

        public void Cancel()
        {
            if (tokenSource != null && IsExectuting)
            {
                tokenSource.Cancel();
            }
        }

        public async void Execute(Action<int> onReportProgress)
        {
            if (onReportProgress == null) throw new ArgumentNullException("onReportProgress");
            try
            {
                this.tokenSource = new CancellationTokenSource();
                this.progress = new Progress<int>();
                this.progress.ProgressChanged += (object sender, int e) => { onReportProgress(e); };

                if (this.IsExectuting)
                {
                    throw new InvalidOperationException("El progreso esta actualmente en operacion");
                }
                this.IsExectuting = true;
                CancellationToken token = this.tokenSource.Token;

                await Task.Run(() =>
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        token.ThrowIfCancellationRequested();
                        Thread.Sleep(100);
                        ((IProgress<int>)progress).Report(i);
                    }
                }, this.tokenSource.Token);
                MessageBox.Show("Progreso exitoso");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Progreso cancelado");               
            }
            catch (AggregateException agrEx)
            {
                MessageBox.Show("Fallo el progreso: " + agrEx.ToString());                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo el progreso: " + ex.ToString());
            }
            finally
            {
                this.tokenSource = null;
                this.progress = null;
                this.IsExectuting = false;
            }
        }
    }
}
