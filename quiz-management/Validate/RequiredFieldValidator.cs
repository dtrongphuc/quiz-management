using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_management.Validate
{
    public partial class RequiredFieldValidator : Component
    {
        private Control _controlToValidate;
        private ErrorProvider _errorProvider = new ErrorProvider();
        private string _initialValue;
        private string _errorMessage;
        private string _regex;
        private bool _isValid;

        public RequiredFieldValidator()
        {
            InitializeComponent();
        }

        public RequiredFieldValidator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        [Category("Behaviour")]
        [Description("Gets or sets the control to validate.")]
        public Control ControlToValidate
        {
            get { return _controlToValidate; }
            set
            {
                _controlToValidate = value;
                if ((_controlToValidate != null) && (!DesignMode))
                {
                    _controlToValidate.Validating += new CancelEventHandler(ControlToValidate_Validating);
                }
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the text for the error message.")]
        public string ErrorMessage { get => _errorMessage; set => _errorMessage = value; }
        public bool IsValid { get => _isValid; set => _isValid = value; }

        [Category("Behaviour")]
        [Description("Gets or sets the default value to validate against.")]
        public string InitialValue { get => _initialValue; set => _initialValue = value; }
        public string Regex { get => _regex; set => _regex = value; }

        public void Validate(CancelEventArgs e)
        {
            string controlValue = ControlToValidate.Text.Trim();
            string initialValue;
            if (_initialValue == null) initialValue = string.Empty;
            else initialValue = _initialValue.Trim();
            string regexValue;
            if (_regex == null) regexValue = string.Empty;
            else regexValue = _regex.Trim();

            if(regexValue != string.Empty) { 
                var regex = new Regex(regexValue, RegexOptions.ECMAScript);
                bool matched = regex.IsMatch(controlValue);
                _isValid = (controlValue != initialValue) && matched;
            } else
            {
                _isValid = (controlValue != initialValue);
            }

            string errorMessage = string.Empty;
            if (!_isValid)
            {
                errorMessage = !(controlValue != initialValue) ? "Dữ liệu rỗng!" : _errorMessage;
                ControlToValidate.Focus();
                e.Cancel = true;
            }
            _errorProvider.SetError(_controlToValidate, errorMessage);
        }

        public void ControlToValidate_Validating(object sender, CancelEventArgs e)
        {
            Validate(e);
        }
    }
}
