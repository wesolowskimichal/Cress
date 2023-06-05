namespace Cress
{
    partial class App
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.appLoginView1 = new Cress.View.AppLoginView();
            this.SuspendLayout();
            // 
            // appLoginView1
            // 
            this.appLoginView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appLoginView1.BackgroundImage")));
            this.appLoginView1.Location = new System.Drawing.Point(0, 0);
            this.appLoginView1.Name = "appLoginView1";
            this.appLoginView1.Size = new System.Drawing.Size(1366, 768);
            this.appLoginView1.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.appLoginView1);
            this.Name = "App";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private View.AppLoginView appLoginView1;
    }
}

