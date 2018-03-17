﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAtec.Seletivo.Domain.Model
{
    public class Question
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }

        public int Score { get; set; }

        public IList<Answer> Answers { get; set; }
    }
}
