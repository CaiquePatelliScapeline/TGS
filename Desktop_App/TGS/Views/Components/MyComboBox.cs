using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace TGS.Views.Components {
    [DefaultEvent("OnSelectedIndexChanged")]
    class MyComboBox : UserControl {
        // Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        // Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        // Properties

        [Category("ComboBox Apperance")]
        public new Color BackColor {
            get => backColor;
            set {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("ComboBox Apperance")]
        public Color IconColor {
            get => iconColor;
            set {
                iconColor = value;
                btnIcon.Invalidate(); // Redraw Icon
            }
        }

        [Category("ComboBox Apperance")]
        public Color ListBackColor {
            get => listBackColor;
            set {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("ComboBox Apperance")]
        public Color ListTextColor {
            get => listTextColor;
            set {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("ComboBox Apperance")]
        public Color BorderColor {
            get => borderColor;
            set {
                borderColor = value;
                base.BackColor = BorderColor;
            }
        }

        [Category("ComboBox Apperance")]
        public int BorderSize {
            get => borderSize;
            set {
                borderSize = value;
                this.Padding = new Padding(BorderSize);
                AdjustComboBoxDimensions();
            }
        }

        [Category("ComboBox Apperance")]
        public override Color ForeColor {
            get {
                return base.ForeColor;
            }
            set {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("ComboBox Apperance")]
        public override Font Font {
            get {
                return base.Font;
            }
            set {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value; // Optional
            }
        }

        [Category("ComboBox Apperance")]
        public string Texts {
            get {
                return lblText.Text;
            }
            set {
                lblText.Text = value;
            }
        }

        [Category("ComboBox Apperance")]
        public ComboBoxStyle DropDownStyle {
            get {
                return cmbList.DropDownStyle;
            }
            set {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple) {
                    cmbList.DropDownStyle = value;
                }
            }
        }

        // Data
        [Category("ComboBox Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items {
            get {
                return cmbList.Items;
            }
        }

        [Category("ComboBox Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource {
            get {
                return cmbList.DataSource;
            }
            set {
                cmbList.DataSource = value;
            }
        }

        [Category("ComboBox Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource {
            get {
                return cmbList.AutoCompleteCustomSource;
            }
            set {
                cmbList.AutoCompleteCustomSource = value;
            }
        }

        [Category("ComboBox Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource {
            get {
                return cmbList.AutoCompleteSource;
            }
            set {
                cmbList.AutoCompleteSource = value;
            }
        }

        [Category("ComboBox Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode {
            get {
                return cmbList.AutoCompleteMode;
            }
            set {
                cmbList.AutoCompleteMode = value;
            }
        }

        [Category("ComboBox Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem {
            get {
                return cmbList.SelectedItem;
            }
            set {
                cmbList.SelectedItem = value;
            }
        }

        [Category("ComboBox Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex {
            get {
                return cmbList.SelectedIndex;
            }
            set {
                cmbList.SelectedIndex = value;
            }
        }

        // Events
        public event EventHandler OnSelectedIndexChanged; // Default event

        // Constructor
        public MyComboBox() {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            // ComboBox: Dropdown List
            cmbList.BackColor = ListBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = ListTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); // Default Event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            // Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = BackColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click); // Open Dropdown List
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            // Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = BackColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click); // Select Combo Box

            // User Control
            this.Controls.Add(lblText); // 2
            this.Controls.Add(btnIcon); // 1
            this.Controls.Add(cmbList); // 0
            this.MinimumSize = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(BorderSize);
            base.BackColor = BorderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        // Private Methods
        private void AdjustComboBoxDimensions() {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point() {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        // Event Methods
        private void Surface_Click(object sender, EventArgs e) {
            // Select Combo Box
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList) {
                cmbList.DroppedDown = true; // Open Dropdown List
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e) {
            // Fields
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            // Draw Arrow Down Icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(IconColor, 2)) {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e) {
            // Open Dropdown List
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e) {
            // Refresh Text
            lblText.Text = cmbList.Text;
        }

        // Default Event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (OnSelectedIndexChanged != null) {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            // Refresh Text
            lblText.Text = cmbList.Text;
        }
    }
}
