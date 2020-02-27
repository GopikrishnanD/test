//***************************************************************************************
//CodeFile                       :   IADService.cs
//Author                         :   Molina Eportal Team, Cognizant
//Date of Creation               :   10 Nov 2010
//NameSpace Name                 :   Molina.ePortal.ADService
//class                          :   IADService 
//Purpose                        :   This interface contains all the Method Signatures for the ADService CRUD Operation
//Change No.        Date        Reason
//0001              03/29/2011  Send Password Link Enhancement 
//0002              04/12/2011  Error Log Fix (Transaction Count Mismatch)
//0003 				01/03/2012	Member Password Issue - Ticket # 839497	
//***************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Molina.ePortal.Model;

namespace Molina.ePortal.ADService
{
    /// <summary>
    /// This interface contains all the Method Signatures for the ADService CRUD Operation
    /// </summary>
    [ServiceContract]
    public interface IADService
    {
        ///// <summary>
        ///// Method to validate if a user exists in the AD.
        ///// </summary>
        ///// <param name="UserName"></param>
        ///// <param name="password"></param>        
        //[OperationContract]
        //void UserExists(string UserName, string password, string usertType);

        /// <summary>
        /// Change the password of the user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        [OperationContract]
        void ChangePassword(string userName, string oldPassword, string newPassword, string userType);
        /// <summary>
        /// Delete User Account
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userType"></param>
        [OperationContract]
        void DeleteUser(string userID, string userType);
        /// <summary>
        /// Get Security Questions from AD
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="usertype"></param>
        /// <returns></returns>
        [OperationContract]
        List<SecurityQuestionAnswer> GetSecurityQuestionAnswer(string userID, string usertype);
        /// <summary>
        /// AD Login
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        [OperationContract]
        ADUserDetails Login(string userID, string password, string userType);
        /// <summary>
        /// Forgot Password
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="newPassword"></param>
        /// <param name="userType"></param>
        /// <param name="expireUserPassword"></param>
        [OperationContract]
        void SetPassword(string userID, string newPassword, string userType, bool expirePassword);

        /// <summary>
        /// Create a New User Account
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userID"></param>
        /// <param name="password"></param>
        /// <param name="emailId"></param>
        /// <param name="userType"></param>
        /// <param name="expireUserPassword"></param>
        [OperationContract]
        int CreateNewUser(string firstName, string lastName, string userID, string password, string emailId, string userType, bool expireUserPassword);

        /// <summary>
        /// Update the Security question and answers in AD
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="questionAnswerList"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        [OperationContract]
        bool UpdateSecurityQuestionAndAnswer(string userID, List<SecurityQuestionAnswer> questionAnswerList, string userType);


        /// <summary>
        /// Enable the user account
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        [OperationContract]
        bool EnableAccount(string userID, string userType);
        // 0001 - Start
        /// <summary>
        /// Method siganture to get Password Status and Security Questions
        /// </summary>
        /// <param name="PasswordStatusAnsQuestionAnswerListUserID"></param>
        /// <returns></returns>
        [OperationContract]
        List<PasswordStatusAndSecurityQuestionAnswers> GetPasswordAndSecurityQuestionAnswers(List<PasswordStatusAndSecurityQuestionAnswers> PasswordStatusAnsQuestionAnswerListUserID);
        /// <summary>
        /// Method signature to Set and Change the Password
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="genPassword"></param>
        /// <param name="newPassword"></param>
        /// <param name="userType"></param>
        [OperationContract]
        void SetAndChangePassword(string userId, string genPassword, string newPassword, string userType);
        // 0001 - End

        // 0002 - Start
        /// <summary>
        /// Check if the user is already exists
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        [OperationContract]
        bool CheckIfUserExists(string userID);
        // 0002 - End
        // 0003 - Start
        /// <summary>
        /// Method signature to Get Account Status
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        [OperationContract]
        string AccountStatus(string userId, string userType);
        // 0003 - End

    }
}
