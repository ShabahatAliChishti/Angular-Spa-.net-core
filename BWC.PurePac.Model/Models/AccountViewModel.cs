using System;
using System.ComponentModel.DataAnnotations;

namespace BWC.PurePac.Models
{ 

    public class ForgottenPasswordParams
    {
        public string LoginID { get; set; }
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        public string IP_Address { get; set; }
        public string GeoLocationInformation { get; set; }
        public string UserAgent { get; set; }
    }
    public class ChangePasswordViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password Confirm")]
        [Compare("NewPassword")]
        public string NewPasswordConfirm { get; set; }
    }
    public class CreateLoginViewModel
    {
        public string LogonID { get; set; }
        public int CandidateID { get; set; }
        public string Message { get; set; }
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
        public string SessionID { get; set; }
        public string IP_Address { get; set; }
        public string GeoLocationInformation { get; set; }
        public string UserAgent { get; set; }
        public string EnteredCode { get; set; }
        public bool Confirmed { get; set; }
    }
    public class ForgottenPasswordVM
    {
        public string EmailAddress { get; set; }        
    }
    public class ChangePasswordUpdateVM
    {
        public int SecurityLogin_ID { get; set; }
        public string Password { get; set; }
        public string PasswordRetype { get; set; }
    }
    public class ResetPasswordUpdateVM
    {
        public string PasswordResetGUID { get; set; }
        public string Password { get; set; }
        public string PasswordRetype { get; set; }
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
        public string SecurityAuditType { get; set; }
        public int SecurityLogon_ID { get; set; }
        public string IP_Address { get; set; }
        public string SecurityAuditDescription { get; set; }
    }
    public class SecurityLogonVM
    {
        public int Id { get; set; }
        public string LogonID { get; set; }
        public string LogonName { get; set; }
        public string LogonPassword { get; set; }
        public string UnEncryptedPassword { get; set; }
        public bool Locked { get; set; }
        public Nullable<System.DateTime> PasswordChangedDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public string LastLoginDetails { get; set; }
        public string LoginStatus { get; set; }
        public int LogonType_ID { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public Guid SecurityLogonPasswordResetGUID { get; set; }
        public bool Active { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
