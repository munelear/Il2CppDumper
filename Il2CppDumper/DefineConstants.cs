﻿using System;
using System.Collections.Generic;

namespace Il2CppDumper
{
    static class DefineConstants
    {
        /*
         * Field Attributes (21.1.5).
         */
        public const int FIELD_ATTRIBUTE_FIELD_ACCESS_MASK = 0x0007;
        public const int FIELD_ATTRIBUTE_COMPILER_CONTROLLED = 0x0000;
        public const int FIELD_ATTRIBUTE_PRIVATE = 0x0001;
        public const int FIELD_ATTRIBUTE_FAM_AND_ASSEM = 0x0002;
        public const int FIELD_ATTRIBUTE_ASSEMBLY = 0x0003;
        public const int FIELD_ATTRIBUTE_FAMILY = 0x0004;
        public const int FIELD_ATTRIBUTE_FAM_OR_ASSEM = 0x0005;
        public const int FIELD_ATTRIBUTE_PUBLIC = 0x0006;

        public const int FIELD_ATTRIBUTE_STATIC = 0x0010;
        public const int FIELD_ATTRIBUTE_INIT_ONLY = 0x0020;
        public const int FIELD_ATTRIBUTE_LITERAL = 0x0040;

        /*
         * Method Attributes (22.1.9)
         */
        public const int METHOD_ATTRIBUTE_MEMBER_ACCESS_MASK = 0x0007;
        public const int METHOD_ATTRIBUTE_COMPILER_CONTROLLED = 0x0000;
        public const int METHOD_ATTRIBUTE_PRIVATE = 0x0001;
        public const int METHOD_ATTRIBUTE_FAM_AND_ASSEM = 0x0002;
        public const int METHOD_ATTRIBUTE_ASSEM = 0x0003;
        public const int METHOD_ATTRIBUTE_FAMILY = 0x0004;
        public const int METHOD_ATTRIBUTE_FAM_OR_ASSEM = 0x0005;
        public const int METHOD_ATTRIBUTE_PUBLIC = 0x0006;

        public const int METHOD_ATTRIBUTE_STATIC = 0x0010;
        public const int METHOD_ATTRIBUTE_FINAL = 0x0020;
        public const int METHOD_ATTRIBUTE_VIRTUAL = 0x0040;

        public const int METHOD_ATTRIBUTE_VTABLE_LAYOUT_MASK = 0x0100;
        public const int METHOD_ATTRIBUTE_REUSE_SLOT = 0x0000;
        public const int METHOD_ATTRIBUTE_NEW_SLOT = 0x0100;

        public const int METHOD_ATTRIBUTE_ABSTRACT = 0x0400;

        public const int METHOD_ATTRIBUTE_PINVOKE_IMPL = 0x2000;

        /*
        * Type Attributes (21.1.13).
        */
        public const int TYPE_ATTRIBUTE_VISIBILITY_MASK = 0x00000007;
        public const int TYPE_ATTRIBUTE_NOT_PUBLIC = 0x00000000;
        public const int TYPE_ATTRIBUTE_PUBLIC = 0x00000001;
        public const int TYPE_ATTRIBUTE_NESTED_PUBLIC = 0x00000002;
        public const int TYPE_ATTRIBUTE_NESTED_PRIVATE = 0x00000003;
        public const int TYPE_ATTRIBUTE_NESTED_FAMILY = 0x00000004;
        public const int TYPE_ATTRIBUTE_NESTED_ASSEMBLY = 0x00000005;
        public const int TYPE_ATTRIBUTE_NESTED_FAM_AND_ASSEM = 0x00000006;
        public const int TYPE_ATTRIBUTE_NESTED_FAM_OR_ASSEM = 0x00000007;


        public const int TYPE_ATTRIBUTE_INTERFACE = 0x00000020;

        public const int TYPE_ATTRIBUTE_ABSTRACT = 0x00000080;
        public const int TYPE_ATTRIBUTE_SEALED = 0x00000100;

        public const int TYPE_ATTRIBUTE_SERIALIZABLE = 0x00002000;

        /*
        * Flags for Params (22.1.12)
        */
        public const int PARAM_ATTRIBUTE_OUT = 0x0002;
        public const int PARAM_ATTRIBUTE_OPTIONAL = 0x0010;


        public static readonly Dictionary<int, string> TypeString = new Dictionary<int, string>
        {
            {1,"void"},
            {2,"bool"},
            {3,"char"},
            {4,"sbyte"},
            {5,"byte"},
            {6,"short"},
            {7,"ushort"},
            {8,"int"},
            {9,"uint"},
            {10,"long"},
            {11,"ulong"},
            {12,"float"},
            {13,"double"},
            {14,"string"},
            {19,"T"},
            {22,"System.TypedReference"},
            {24,"IntPtr"},
            {25,"UIntPtr"},
            {28,"object"},
            {30,"T"},
        };

        public static Version Unity20183 = new Version(2018, 3);
        public static Version Unity20191 = new Version(2019, 1);
    }

    static class ElfConstants
    {
        public const int DT_PLTGOT = 3;
        public const int DT_STRTAB = 5;
        public const int DT_SYMTAB = 6;
        public const int DT_RELA = 7;
        public const int DT_RELASZ = 8;
        public const int DT_INIT = 12;
        public const int DT_REL = 17;
        public const int DT_RELSZ = 18;
        public const int DT_INIT_ARRAY = 25;
        public const int DT_INIT_ARRAYSZ = 27;

        public const int R_ARM_ABS32 = 2;

        public const int R_386_32 = 1;

        public const int R_AARCH64_ABS64 = 257;
        public const int R_AARCH64_RELATIVE = 1027;
    }
}