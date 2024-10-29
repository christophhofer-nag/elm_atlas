using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM_ATLAS
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

    public class RoundedButton : Button
    {
        private Color originalForeColor;  // Store the original font color
        private Color hoverForeColor = Color.Red; // Set the hover font color (change as desired)

        public RoundedButton()
        {
            // Store the default forecolor and subscribe to the MouseEnter/MouseLeave events
            originalForeColor = this.ForeColor;
            this.MouseEnter += RoundedButton_MouseEnter;
            this.MouseLeave += RoundedButton_MouseLeave;
        }

        // Event when mouse enters button area
        private void RoundedButton_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            //93; 95; 239
            this.BackColor = Color.FromArgb(93, 95, 239);
            this.Invalidate();  // Force the button to repaint
        }

        // Event when mouse leaves button area
        private void RoundedButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = originalForeColor;
            this.Invalidate();  // Force the button to repaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a GraphicsPath to define the rounded corners
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 20; // Adjust the corner radius as needed
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Create rounded rectangle
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90); // Top-left
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90); // Top-right
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left
            path.CloseAllFigures();

            // Set the Region of the button to be the rounded rectangle
            this.Region = new Region(path);

            // Fill the button with background color
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw button text
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, rect, this.ForeColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

}
