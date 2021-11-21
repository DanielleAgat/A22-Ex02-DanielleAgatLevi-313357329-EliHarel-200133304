using FacebookWrapper;

namespace Logic
{
     public class BasicFacebookLogic
     {
          private const string k_AppId = "1820134424859923";
          public static readonly string[] sr_ConstantPermissions = { "email", "public_profile", "user_birthday" };

          public static FacebookWrapper.LoginResult Login(int i_StartPoint, string[] i_Permissions)
          {
               string[] permissions = getCheckedPermissions(i_StartPoint, i_Permissions);

               return FacebookService.Login(k_AppId, permissions);
          }

          private static string[] getCheckedPermissions(int i_StartPoint, string[] i_Permissions)
          {
               int i = i_StartPoint;

               for (int j = 0; j < sr_ConstantPermissions.Length; j++, i++)
               {
                    i_Permissions[i] = sr_ConstantPermissions[j];
               }

               return i_Permissions;
          }
     }
}