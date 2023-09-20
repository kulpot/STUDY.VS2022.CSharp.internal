using System;

//ref link:https://www.youtube.com/watch?v=zyfMKUw7OYQ&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=5
// assembly - .dll, .exe, also creates module
// assembly - logical grouping of files

// Metadata - ex: that starts with a (dot).assembly - is a executable that just data sits there and does absolutely nothing(see attribute and reflections)

// cmd type - erase *.* - erase everything, 

/*      ------------CMD---------------------
 *      
C:\Users\sunny\source\repos\CSharp Assemblies>cd CSharp Assemblies

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies

20/09/2023  07:00 am    <DIR>          .
20/09/2023  07:00 am    <DIR>          ..
20/09/2023  06:54 am               189 App.config
20/09/2023  06:54 am    <DIR>          bin
20/09/2023  06:55 am             2,384 CSharp Assemblies.csproj
20/09/2023  06:54 am    <DIR>          obj
20/09/2023  07:00 am               272 Program.cs
20/09/2023  06:54 am    <DIR>          Properties
               3 File(s)          2,845 bytes
               5 Dir(s)  490,495,135,744 bytes free

   C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>csc Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies

20/09/2023  07:04 am    <DIR>          .
20/09/2023  07:04 am    <DIR>          ..
20/09/2023  06:54 am               189 App.config
20/09/2023  06:54 am    <DIR>          bin
20/09/2023  06:55 am             2,384 CSharp Assemblies.csproj
20/09/2023  06:54 am    <DIR>          obj
20/09/2023  07:00 am               272 Program.cs
20/09/2023  07:04 am             4,096 Program.exe
20/09/2023  06:54 am    <DIR>          Properties
               4 File(s)          6,941 bytes
               5 Dir(s)  490,494,267,392 bytes free

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>Program.exe
Helllo
      
  C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>ildasm /out:moo.txt Program.exe
  
  C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>moo.txt
--------------------------NOTEPAD: moo.txt -----------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Program.exe
// MVID: {25CE2C0C-B0CD-464C-B898-7CFF4B2CE2EC}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06E50000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Helllo"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


-------------------------------------------------------------------------
  
C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies

20/09/2023  07:16 am    <DIR>          .
20/09/2023  07:16 am    <DIR>          ..
20/09/2023  06:54 am               189 App.config
20/09/2023  06:54 am    <DIR>          bin
20/09/2023  06:55 am             2,384 CSharp Assemblies.csproj
20/09/2023  07:11 am             1,128 moo.res
20/09/2023  07:11 am             4,898 moo.txt
20/09/2023  06:54 am    <DIR>          obj
20/09/2023  07:16 am             7,603 Program.cs
20/09/2023  07:04 am             4,096 Program.exe
20/09/2023  06:54 am    <DIR>          Properties
               6 File(s)         20,298 bytes
               5 Dir(s)  490,486,525,952 bytes free

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>erase *.*
C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies

20/09/2023  07:20 am    <DIR>          .
20/09/2023  07:20 am    <DIR>          ..
20/09/2023  06:54 am    <DIR>          bin
20/09/2023  06:54 am    <DIR>          obj
20/09/2023  07:20 am             8,675 Program.cs
20/09/2023  06:54 am    <DIR>          Properties
               1 File(s)          8,675 bytes
               5 Dir(s)  490,484,318,208 bytes free

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>csc /t:module /out:MeFirstModule.netmodule Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies

20/09/2023  07:24 am    <DIR>          .
20/09/2023  07:24 am    <DIR>          ..
20/09/2023  06:54 am    <DIR>          bin
20/09/2023  07:24 am             3,072 MeFirstModule.netmodule
20/09/2023  06:54 am    <DIR>          obj
20/09/2023  07:24 am             9,666 Program.cs
20/09/2023  06:54 am    <DIR>          Properties
               2 File(s)         12,738 bytes
               5 Dir(s)  490,480,594,944 bytes free

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>MeFirstModule.netmodule 
------ cant be executed directly, even windows dont know
------ cant create reference

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>ildasm /out:moo.txt MeFirstModule.netmodule
C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>moo.txt
----------------------------------NOTEPAD: moo.txt-----------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.module MeFirstModule.netmodule
// MVID: {62682C77-E743-451F-9512-EC992088158A}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x057F0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit MeFirstModule
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Hello() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Helllo from module 1"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MeFirstModule::Hello

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MeFirstModule::.ctor

} // end of class MeFirstModule


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


-------------------------------------------------------------------------

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>csc /t:module /out:MeSecondModule.netmodule Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\CSharp Assemblies\CSharp Assemblies

20/09/2023  07:33 am    <DIR>          .
20/09/2023  07:33 am    <DIR>          ..
20/09/2023  06:54 am    <DIR>          bin
20/09/2023  07:24 am             3,072 MeFirstModule.netmodule
20/09/2023  07:32 am             3,072 MeSecondModule.netmodule
20/09/2023  07:27 am               692 moo.res
20/09/2023  07:27 am             1,635 moo.txt
20/09/2023  06:54 am    <DIR>          obj
20/09/2023  07:33 am            12,876 Program.cs
20/09/2023  06:54 am    <DIR>          Properties
               5 File(s)         21,347 bytes
               5 Dir(s)  490,476,625,920 bytes free

C:\Users\sunny\source\repos\Modules\Modules>csc /addmodule:MeFirstModule.netmodule,MeSecondModule.netmodule Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Modules\Modules>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Modules\Modules

20/09/2023  07:55 am    <DIR>          .
20/09/2023  07:55 am    <DIR>          ..
20/09/2023  07:36 am    <DIR>          bin
20/09/2023  07:43 am             3,072 MeFirstModule.netmodule
20/09/2023  07:46 am             3,072 MeSecondModule.netmodule
20/09/2023  07:43 am               692 moo.res
20/09/2023  07:43 am             1,635 moo.txt
20/09/2023  07:36 am    <DIR>          obj
20/09/2023  07:53 am            13,844 Program.cs
20/09/2023  07:55 am             4,096 Program.exe
20/09/2023  07:36 am    <DIR>          Properties
               6 File(s)         26,411 bytes
               5 Dir(s)  490,491,740,160 bytes free

C:\Users\sunny\source\repos\Modules\Modules>Program.exe
Helllo from module 1
Helllo from module 2

------- using reflections
C:\Users\sunny\source\repos\Modules\Modules>ildasm /out:moo.txt Program.exe

C:\Users\sunny\source\repos\Modules\Modules>moo.txt
----------------------NOTEPAD: moo.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.module extern MeFirstModule.netmodule
.module extern MeSecondModule.netmodule
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.file MeFirstModule.netmodule
    .hash = (E2 1F D4 B0 AB 38 EE 6D 0E D6 F0 8B C1 50 B0 D1   // .....8.m.....P..
             D0 C9 59 CA )                                     // ..Y.
.file MeSecondModule.netmodule
    .hash = (FE 1D 1F 87 5C 79 BA E5 61 81 38 60 91 20 04 44   // ....\y..a.8`. .D
             84 BF F5 A8 ) 
.module Program.exe
// MVID: {EF0E7364-A1DB-45CB-A120-198BB560A3C4}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x04DE0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  call       void [.module MeFirstModule.netmodule]MeFirstModule::Hello()
    IL_0006:  nop
    IL_0007:  call       void [.module MeSecondModule.netmodule]MeSecondModule::Hello()
    IL_000c:  nop
    IL_000d:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


----------------------------------------------------------------------



C:\Users\sunny\source\repos\internal\internal>Program.exe
Helllo from module 1
Helllo from module 2

C:\Users\sunny\source\repos\internal\internal>erase Program.exe

C:\Users\sunny\source\repos\internal\internal>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\internal\internal

21/09/2023  04:53 am    <DIR>          .
21/09/2023  04:53 am    <DIR>          ..
21/09/2023  04:28 am    <DIR>          bin
21/09/2023  04:41 am             3,072 MeFirstModule.netmodule
21/09/2023  04:44 am             3,072 MeSecondModule.netmodule
21/09/2023  04:46 am             1,128 moo.res
21/09/2023  04:46 am             5,439 moo.txt
21/09/2023  04:28 am    <DIR>          obj
21/09/2023  04:53 am            21,052 Program.cs
21/09/2023  04:28 am    <DIR>          Properties
               5 File(s)         33,763 bytes
               5 Dir(s)  490,466,684,928 bytes free

C:\Users\sunny\source\repos\internal\internal>csc /addmodule:MeFirstModule.netmodule,MeSecondModule.netmodule /t:library /out:MeDll.dll
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\internal\internal>ildasm /out:moo.txt medll.dll

C:\Users\sunny\source\repos\internal\internal>moo.txt


--------------------------NOTEPAD: moo.txt----------------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MeDll
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.file MeFirstModule.netmodule
    .hash = (A3 D8 67 54 7E 6D F5 C3 23 B2 D9 FE DD 81 9D 27   // ..gT~m..#......'
             5D 15 B6 B3 )                                     // ]...
.file MeSecondModule.netmodule
    .hash = (A9 1B 33 DA 53 AF 70 4E 5D 73 9D B0 FC F1 37 CC   // ..3.S.pN]s....7.
             1C 5B 3F 8B )                                     // .[?.
.module MeDll.dll
// MVID: {E9F3501D-B768-4A6B-9B6E-1F5B93B06AD0}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x07350000

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


--------------------------------------------------------------------------------

C:\Users\sunny\source\repos\internal\internal>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\internal\internal

21/09/2023  04:59 am    <DIR>          .
21/09/2023  04:59 am    <DIR>          ..
21/09/2023  04:28 am    <DIR>          bin
21/09/2023  04:56 am             3,072 MeDll.dll
21/09/2023  04:41 am             3,072 MeFirstModule.netmodule
21/09/2023  04:44 am             3,072 MeSecondModule.netmodule
21/09/2023  04:57 am               636 moo.res
21/09/2023  04:57 am             1,900 moo.txt
21/09/2023  04:28 am    <DIR>          obj
21/09/2023  04:59 am            24,323 Program.cs
21/09/2023  04:28 am    <DIR>          Properties
               6 File(s)         36,075 bytes
               5 Dir(s)  490,463,272,960 bytes free

C:\Users\sunny\source\repos\internal\internal>erase moo.*

C:\Users\sunny\source\repos\internal\internal>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\internal\internal

21/09/2023  05:00 am    <DIR>          .
21/09/2023  05:00 am    <DIR>          ..
21/09/2023  04:28 am    <DIR>          bin
21/09/2023  04:56 am             3,072 MeDll.dll
21/09/2023  04:41 am             3,072 MeFirstModule.netmodule
21/09/2023  04:44 am             3,072 MeSecondModule.netmodule
21/09/2023  04:28 am    <DIR>          obj
21/09/2023  04:59 am            24,323 Program.cs
21/09/2023  04:28 am    <DIR>          Properties
               4 File(s)         33,539 bytes
               5 Dir(s)  490,462,138,368 bytes free

-----------------PROTECTED LEVEL INTERNAL ASSEMBLY---------------------------------
-----------------cant reference to main CS-----------
C:\Users\sunny\source\repos\internal\internal>csc /r:MeDll.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

Program.cs(648,9): error CS0122: 'MeFirstModule' is inaccessible due to its protection level
Program.cs(649,9): error CS0122: 'MeSecondModule' is inaccessible due to its protection level

 * 
 */

//class MainClass
//{
//    static void Main()
//    {
//        Console.WriteLine("Helllo");
//    }
//}

//class MeFirstModule
//{
//    public static void Hello()
//    {
//        Console.WriteLine("Helllo from module 1");
//    }
//}

//class MeSecondModule
//{
//    public static void Hello()
//    {
//        Console.WriteLine("Helllo from module 2");
//    }
//}


//internal MainClass    //the default,and not visible for assembly or private only for assembly
class MainClass
{
    static void Main()
    {
        MeFirstModule.Hello();
        MeSecondModule.Hello();
    }
}

