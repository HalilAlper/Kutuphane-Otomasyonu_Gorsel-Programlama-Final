using System.Drawing;
using System.Windows.Forms;

//Bu kod, NESNEADIPencere pencerelerinde 90 derecelik Label'lar için kullanılmış Override nesnesidir.
//Bu nesneyi internetten aldım.
//Kaynak: https://stackoverflow.com/questions/12601774/how-can-i-flip-rotate-the-label-in-c-windows-forms

class VerticalLabel : Label
{
    public int RotateAngle { get; set; }  // to rotate your text
    public string NewText { get; set; }   // to draw text
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        Brush b = new SolidBrush(this.ForeColor);
        e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
        e.Graphics.RotateTransform(this.RotateAngle);
        e.Graphics.DrawString(this.NewText, this.Font, b, 0f, 0f);
        base.OnPaint(e);
    }
}