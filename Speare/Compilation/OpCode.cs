﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speare.Compilation
{
    public enum OpCode : short
    {
        None,
        PushScope,
        PopScope,
        Constant,
        Move,
        Compare,
        Jump,
        JumpIfTrue,
        Call,
        Method,
        Return,
        Interop,
        Add,
        Subtract,
        Divide,
        Multiply,
        Modulo,
        Equal,
        Not,
        Exit,
        DebugPrint
    }
}
