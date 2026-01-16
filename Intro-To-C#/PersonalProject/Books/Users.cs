using Intro_To_CSharp.Basics.OOP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intro_To_CSharp.PersonalProject.Books
{
    [Flags]
    enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Add = 3,
        Delete = 4,
        Edit = 5,
        Full_Control = Read | Write | Add | Delete | Delete
    }
    static class Roles
    {
        public static readonly Permission Guest = Permission.Read;
        public static readonly Permission Patron = Permission.Read | Permission.Write;
        public static readonly Permission Admin = Permission.Full_Control;
    }
    class PermissionManagement
    {
        private static readonly Dictionary<string, Permission> roleMap = new()
        {
            { "Admin", Roles.Admin },
            { "Patron", Roles.Patron },
            { "Guest", Roles.Guest },

        };

        // Helper to check if a permission contains all required flags
        private static bool HasPermissions(Permission userPermission, Permission required)
        {
            if (required == Permission.None)
                return userPermission == Permission.None; 

            return (userPermission & required) == required;
        }
        public PermissionManagement() {

            
        
        }
    }
    
    internal class Users
    {
    }
}
