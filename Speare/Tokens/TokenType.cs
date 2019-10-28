﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speare.Tokens
{
    public enum TokenType
    {
        None,
        BeginBlock,
        EndBlock,
        Speaker,
        Sentence,
        MethodDefinition,
        MethodCall,
        Identifier,
        ParameterSeparator,
        BeginParameters,
        EndParameters,
        Integer,
        Double,
        String,
        Error,
        EOF
    }
}