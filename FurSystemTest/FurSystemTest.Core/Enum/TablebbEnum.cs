﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core
{
        public enum Whether_bb
        {

            [Display(Name = "请选择")]
            Null = 9,
            [Display(Name = "是")]
            Yes = 1,
            [Display(Name = "否")]
            No = 2,
        }
        public enum Nation_bb
        {
            [Display(Name = "请选择")]
            Null = 9,
            [Display(Name = "汉族")]
            One = 1,
            [Display(Name = "蒙古族")]
            Two = 2,
            [Display(Name = "藏族")]
            three = 3,
            [Display(Name = "壮族")]
            four = 4,
            [Display(Name = "回族")]
            five = 5,
            [Display(Name = "满族")]
            six = 6,
            [Display(Name = "维吾尔族")]
            seven = 7,
            [Display(Name = "其他")]
            other = 8,
        }
        public enum Gender_bb
        {
            [Display(Name = "请选择")]
            Null = 9,
            [Display(Name = "男")]
            male = 1,
            [Display(Name = "女")]
            female = 2,
        }

    }

