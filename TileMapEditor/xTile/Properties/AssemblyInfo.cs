﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("xTile")]
[assembly: AssemblyProduct("xTile")]
[assembly: AssemblyDescription("XNA Tile Engine")]
[assembly: AssemblyCompany("Colin Vella")]
[assembly: AssemblyCopyright("Copyright © Colin Vella 2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7044cf96-9f36-4bbd-a2d8-39cdc600778e")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.2.3.0")]

#if WINDOWS

[assembly: AssemblyFileVersionAttribute("1.2.3.0")]

#elif XBOX

#elif ZUNE

#elif WINDOWS_PHONE

[assembly: AssemblyFileVersionAttribute("1.2.3.0")]
      
#else

#error The platform is not specified or is unsupported by this game.

#endif

