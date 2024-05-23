using System;
using System.ComponentModel.DataAnnotations;

namespace AngularSpaWithNetCore6._0.Models
{ 

    public class ForgottenPasswordParams
    {
        public string LoginID { get; set; } = String.Empty;
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserID { get; set; }= String.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }= String.Empty;

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public string IP_Address { get; set; }= String.Empty;
        public string GeoLocationInformation { get; set; }= String.Empty;
        public string UserAgent { get; set; }= String.Empty;
    }
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserID { get; set; }= String.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }= String.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }= String.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password Confirm")]
        [Compare("NewPassword")]
        public string NewPasswordConfirm { get; set; }= String.Empty;
    }
    public class CreateLoginViewModel
    {
        public string LogonID { get; set; }= String.Empty;
        public int CandidateID { get; set; }
        public string Message { get; set; }= String.Empty;
        public bool Status { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class ResetPasswordVM
    {       
        public int SecurityLogon_ID { get; set; }
        public int Member_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class Confirm2FACodeVM
    {
        public int ID { get; set; }
        public string SessionID { get; set; }= String.Empty;
        public string IP_Address { get; set; }= String.Empty;
        public string GeoLocationInformation { get; set; }= String.Empty;
        public string UserAgent { get; set; }= String.Empty;
        public string EnteredCode { get; set; }= String.Empty;
        public bool Confirmed { get; set; }
    }
    public class ForgottenPasswordVM
    {
        public string EmailAddress { get; set; } = String.Empty;
    }
    public class ChangePasswordUpdateVM
    {
        public int SecurityLogin_ID { get; set; }
        public string Password { get; set; }= String.Empty;
        public string PasswordRetype { get; set; }= String.Empty;
    }
    public class ResetPasswordUpdateVM
    {
        public string PasswordResetGUID { get; set; }= String.Empty;
        public string Password { get; set; }= String.Empty;
        public string PasswordRetype { get; set; }= String.Empty;
    }
    public class LoginLockUnlockVM
    {
        public int SecurityLogon_ID { get; set; }
        public int Member_ID { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class SecurityAuditVM
    {
        public int ID { get; set; }
        public string SecurityAuditType { get; set; }= String.Empty;
        public int SecurityLogon_ID { get; set; }
        public string IP_Address { get; set; }= String.Empty;
        public string SecurityAuditDescription { get; set; }= String.Empty;
    }
    public class SecurityLogonVM
    {
        public int Id { get; set; }
        public string LogonID { get; set; }= String.Empty;
        public string LogonName { get; set; }= String.Empty;
        public string LogonPassword { get; set; }= String.Empty;
        public string UnEncryptedPassword { get; set; }= String.Empty;
        public bool Locked { get; set; }
        public Nullable<System.DateTime> PasswordChangedDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public string LastLoginDetails { get; set; }= String.Empty;
        public string LoginStatus { get; set; }= String.Empty;
        public int LogonType_ID { get; set; }
        public string EmailAddress { get; set; }= String.Empty;
        public string MobileNumber { get; set; }= String.Empty;
        public Guid SecurityLogonPasswordResetGUID { get; set; }
        public bool Active { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }= String.Empty;
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
