using System;
using Microsoft.AspNetCore.Mvc;
using myAngularProj.Models;
using System.Collections.Generic;

namespace myAngularProj.Models
{
    public class RegisterRepo
    {
        public List<RegisterModel>ListCollection=new List<RegisterModel>();
        public void AddUser(RegisterModel reg){
        ListCollection.Add(reg);
      }
    }
}