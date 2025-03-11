using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace arsb_uni
{
    public partial class Form1 : Form
    {
        Button new_student = new Button();
        Button current_student = new Button();
        int incremID = 1000;
        public Form1()
        {
            InitializeComponent();
            arab();
        }
        private void arab()
        {
            Text = "Al Arab university";
            BackColor = Color.Coral;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;

            //new student button
            new_student.Text = "New Student";
            new_student.ForeColor = Color.Coral;
            new_student.BackColor = Color.White;
            new_student.Font = new Font(new_student.Font.FontFamily, 12);
            new_student.Location = new Point(600, 200);
            new_student.Size = new Size(150, 30);
            new_student.Click += new EventHandler(newsudent_click);
            this.Controls.Add(new_student);
            
            //current student btton
            current_student.Text = "Current student";
            current_student.ForeColor = Color.Coral;
            current_student.BackColor = Color.White;
            current_student.Font = new Font(current_student.Font.FontFamily, 12);
            current_student.Location = new Point(600, 250);
            current_student.Click += new EventHandler(curentstudent_click);
            current_student.Size = new Size(150, 30);
            this.Controls.Add(current_student);
        }
        private void curentstudent_click(object sender,EventArgs e)
        {
            Form f2 = new Form();
            f2.Show();
            this.Hide();
            f2.BackColor = Color.Coral;
            f2.Text = "CURRENT STUDENT";
            f2.WindowState = FormWindowState.Maximized;

            Label id = new Label();
            id.Text = "Enter your Acadamic ID :";
            id.Location = new Point(500, 350);
            id.Size = new Size(250, 150);
            id.Font = new Font(id.Font.FontFamily, 15,FontStyle.Bold);
            f2.Controls.Add(id);

            TextBox txtid = new TextBox();
            txtid.Location = new Point(700,355);
            txtid. AutoSize = true;
            f2.Controls.Add(txtid);

            //search button
            Button search = new Button();
            search.Text = "Search..";
            search.Location = new Point(572,550);
            search.ForeColor = Color.White;
            search.BackColor = Color.Blue;
            search.Size = new Size(150, 30);
            f2.Controls.Add(search);

            //close button
            Button close = new Button();
            close.Text = "Close";
            close.Location = new Point(1100, 650);
            close.Size = new Size(150, 30);
            close.BackColor = Color.White;
            close.Click += new EventHandler(close_click);
            f2.Controls.Add(close);
        }
        private void newsudent_click(object sender,EventArgs e)
        {
            Form f1 = new Form();
            f1.Show();
            this.Hide();
            f1.BackColor = Color.Coral;
            f1.Text = "NEW STUDENT";
            f1.WindowState = FormWindowState.Maximized;

            // Main GroupBox Container
            GroupBox mainGroup = new GroupBox();
            mainGroup.Text = "Student Information";
            mainGroup.Location = new Point(10, 10);
            mainGroup.Size = new Size(700, 400);
            mainGroup.Font = new Font("Arial", 14, FontStyle.Bold);
            f1.Controls.Add(mainGroup);

            // Student Name
            Label lblName = new Label();
            lblName.Text = "Full Name:";
            lblName.Location = new Point(20, 30);
            lblName.Size = new Size(120, 30);
            lblName.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(lblName);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(150, 30);
            txtName.Size = new Size(300, 30);
            txtName.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(txtName);

            // Gender
            Label lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(20, 80);
            lblGender.Size = new Size(120, 30);
            lblGender.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(lblGender);

            RadioButton maleRadio = new RadioButton();
            maleRadio.Text = "Male";
            maleRadio.Location = new Point(150, 80);
            maleRadio.Font = new Font("Arial", 12);
            maleRadio.AutoSize = true;
            mainGroup.Controls.Add(maleRadio);

            RadioButton femaleRadio = new RadioButton();
            femaleRadio.Text = "Female";
            femaleRadio.Location = new Point(250, 80);
            femaleRadio.Font = new Font("Arial", 12);
            femaleRadio.AutoSize = true;
            mainGroup.Controls.Add(femaleRadio);

            // Country
            Label lblCountry = new Label();
            lblCountry.Text = "Country:";
            lblCountry.Location = new Point(20, 130);
            lblCountry.Size = new Size(120, 30);
            lblCountry.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(lblCountry);

            ComboBox cmbCountry = new ComboBox();
            cmbCountry.Location = new Point(150, 130);
            cmbCountry.Size = new Size(300, 30);
            cmbCountry.Font = new Font("Arial", 12);
            cmbCountry.Items.AddRange(new object[] {
        "Yemen",
        "Saudi Arabia",
        "UAE",
        "Oman",
        "Kuwait",
        "Qatar",
        "Other"
    });
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            mainGroup.Controls.Add(cmbCountry);

            // Contact Information
            Label lblContacts = new Label();
            lblContacts.Text = "Contact Information:";
            lblContacts.Location = new Point(20, 180);
            lblContacts.Size = new Size(200, 30);
            lblContacts.Font = new Font("Arial", 12,FontStyle.Italic);
            mainGroup.Controls.Add(lblContacts);

            // Phone
            Label lblPhone = new Label();
            lblPhone.Text = "Phone:";
            lblPhone.Location = new Point(40, 220);
            lblPhone.Size = new Size(80, 30);
            lblPhone.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(lblPhone);

            TextBox txtPhone = new TextBox();
            txtPhone.Location = new Point(150, 220);
            txtPhone.Size = new Size(300, 30);
            txtPhone.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(txtPhone);

            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(40, 260);
            lblEmail.Size = new Size(80, 30);
            lblEmail.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(lblEmail);

            TextBox txtEmail = new TextBox();
            txtEmail.Location = new Point(150, 260);
            txtEmail.Size = new Size(300, 30);
            txtEmail.Font = new Font("Arial", 12);
            mainGroup.Controls.Add(txtEmail);

            //new groupbox
            // Academic Info GroupBox
            GroupBox academicGroup = new GroupBox();
            academicGroup.Text = "Academic Info";
            academicGroup.Location = new Point(10, 450); 
            academicGroup.Size = new Size(700, 200);
            academicGroup.Font = new Font("Arial", 12, FontStyle.Bold);
            f1.Controls.Add(academicGroup);

            // High School Name
            Label lblHighSchool = new Label();
            lblHighSchool.Text = "High School:";
            lblHighSchool.Location = new Point(20, 30);
            lblHighSchool.Size = new Size(120, 30);
            lblHighSchool.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(lblHighSchool);

            TextBox txtHighSchool = new TextBox();
            txtHighSchool.Location = new Point(150, 30);
            txtHighSchool.Size = new Size(200, 20);
            txtHighSchool.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(txtHighSchool);

            // Graduation Year
            Label lblGraduationYear = new Label();
            lblGraduationYear.Text = "Graduation Year:";
            lblGraduationYear.Location = new Point(20, 70);
            lblGraduationYear.Size = new Size(140, 30);
            lblGraduationYear.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(lblGraduationYear);

            NumericUpDown numGraduationYear = new NumericUpDown();
            numGraduationYear.Location = new Point(170, 70);
            numGraduationYear.Size = new Size(120, 30);
            numGraduationYear.Minimum = 2000;
            numGraduationYear.Maximum = DateTime.Now.Year;
            numGraduationYear.Value = DateTime.Now.Year - 1;
            academicGroup.Controls.Add(numGraduationYear);

            // GPA
            Label lblGPA = new Label();
            lblGPA.Text = "GPA:";
            lblGPA.Location = new Point(20, 110);
            lblGPA.Size = new Size(80, 30);
            lblGPA.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(lblGPA);

            TextBox txtGPA = new TextBox();
            txtGPA.Location = new Point(170, 110);
            txtGPA.Size = new Size(120, 30);
            txtGPA.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(txtGPA);

            // Certificate Type
            Label lblCertificate = new Label();
            lblCertificate.Text = "Certificate Type:";
            lblCertificate.Location = new Point(350, 30);
            lblCertificate.Size = new Size(150, 30);
            lblCertificate.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(lblCertificate);

            CheckBox chkScientific = new CheckBox();
            chkScientific.Text = "Scientific";
            chkScientific.Location = new Point(350, 70);
            chkScientific.Size = new Size(120, 30);
            chkScientific.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(chkScientific);

            CheckBox chkLiterary = new CheckBox();
            chkLiterary.Text = "Literary";
            chkLiterary.Location = new Point(350, 110);
            chkLiterary.Size = new Size(120, 30);
            chkLiterary.Font = new Font("Arial", 12);
            academicGroup.Controls.Add(chkLiterary);

            // اختيار التخصص
            GroupBox specializedGroup = new GroupBox();
            specializedGroup.Text = "Specialized Requirements";
            specializedGroup.Location = new Point(720, 10); 
            specializedGroup.Size = new Size(630, 150);
            specializedGroup.Font = new Font("Arial", 12, FontStyle.Bold);
            f1.Controls.Add(specializedGroup);

            // College Selection
            Label lblCollege = new Label();
            lblCollege.Text = "Select College:";
            lblCollege.Location = new Point(20, 30);
            lblCollege.Size = new Size(120, 30);
            lblCollege.Font = new Font("Arial", 12);
            specializedGroup.Controls.Add(lblCollege);

            ComboBox cmbCollege = new ComboBox();
            cmbCollege.Location = new Point(150, 30);
            cmbCollege.Size = new Size(300, 30);
            cmbCollege.Font = new Font("Arial", 12);
            cmbCollege.Items.AddRange(new object[] {
        "College of Engineering",
        "College of Medicine",
        "College of Business",
        "College of Computer Science",
        "College of Law",
        "College of Arts"
    });
            cmbCollege.DropDownStyle = ComboBoxStyle.DropDownList;
            specializedGroup.Controls.Add(cmbCollege);

            // Major
            Label lblMajor = new Label();
            lblMajor.Text = "Major:";
            lblMajor.Location = new Point(20, 80);
            lblMajor.Size = new Size(80, 30);
            lblMajor.Font = new Font("Arial", 12);
            specializedGroup.Controls.Add(lblMajor);

            TextBox txtMajor = new TextBox();
            txtMajor.Location = new Point(150, 80);
            txtMajor.Size = new Size(300, 30);
            txtMajor.Font = new Font("Arial", 12);
            specializedGroup.Controls.Add(txtMajor);

            // الموافقة على االسياسة 
            CheckBox Agreement = new CheckBox();
            Agreement.Text = "I agree to the university's terms and conditions";
            Agreement.Location = new Point(30, 660);
            Agreement.Size = new Size(400, 30);
            Agreement.Checked = true;
            Agreement.Font = new Font("Arial", 10, FontStyle.Regular);
            f1.Controls.Add(Agreement);

            //submet
            Button submet = new Button();
            submet.Text = "Submet";
            submet.Location = new Point(900, 650);
            submet.Size = new Size(150, 30);
            submet.BackColor = Color.Blue;
            submet.ForeColor = Color.White;
            submet.Click += new EventHandler(submet_click);
            f1.AcceptButton = submit;
            f1.Controls.Add(submet);

            //close button
            Button close = new Button();
            close.Text = "Close";
            close.Location = new Point(1100,650);
            close.Size = new Size(150, 30);
            close.BackColor = Color.White;
            close.Click += new EventHandler(close_click);
            f1.Controls.Add(close);


        }
        private void close_click(object sender,EventArgs e)
        {
            Close();
        }
        private void submet_click(object sender,EventArgs e)
        {
            
           int formattedId = incremID + 1;
 MessageBox.Show($"Registration Successful!\n\n" +
                $"Your Student ID: {formattedId}\n" +
                $"This ID has been sent to your email.");

        }

    }
}
