﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006-2018, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//  Version 4.7.0.0  www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Security;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion("4.71.0.0")]
[assembly: AssemblyFileVersion("4.71.558.0")]
[assembly: AssemblyInformationalVersion("4.71.558.0")]
[assembly: AssemblyCopyright("© Component Factory Pty Ltd, 2006-2018. Then modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2017-2018. All rights reserved.")]
[assembly: AssemblyProduct("Krypton Design")]
[assembly: AssemblyDefaultAlias("ComponentFactory.Krypton.Design.dll")]
[assembly: AssemblyTitle("ComponentFactory.Krypton.Design")]
[assembly: AssemblyCompany("Component Factory Pty Ltd, Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV)")]
[assembly: AssemblyDescription("ComponentFactory.Krypton.Design")]
[assembly: AssemblyConfiguration("Production")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: StringFreezing]
[assembly: ComVisible(true)]
[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers()]
[assembly: Dependency("System", LoadHint.Always)]
[assembly: Dependency("System.Design", LoadHint.Sometimes)]
[assembly: Dependency("System.Drawing", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms", LoadHint.Always)]
[assembly: SecurityRules(SecurityRuleSet.Level1)]