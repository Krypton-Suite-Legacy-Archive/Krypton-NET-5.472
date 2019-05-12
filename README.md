# <img src="https://github.com/Wagnerp/Krypton-NET-4.72/blob/master/Assets/PNG/Square%20Design/Main%20Icon/64%20x%2064/Square%20Design%2064%20x%2064%20New%20Green.png"> .NET 5.472

=======

| NuGet | Current NuGet Version | Github License |
|---|---|---|
| [![NuGet](https://img.shields.io/badge/NuGet-Krypton%20.NET%205.472-green.svg)](https://www.nuget.org/packages/KryptonToolkitSuite5472/) | ![Nuget](https://img.shields.io/nuget/v/KryptonToolkitSuite5472.svg)| ![GitHub](https://img.shields.io/github/license/Wagnerp/Krypton-NET-5.472.svg) | 

=======

# ["Toolkit help index"](https://rawgit.com/Wagnerp/Krypton-NET-4.7/master/Help/Output/index.html)

=======

# <img src="https://github.com/Wagnerp/Krypton-NET-Version-Dashboard/blob/master/Assets/Icons/PNG/KR%2064%20%20x%2064%20Purple.png" /><a href="https://github.com/Wagnerp/Krypton-NET-Version-Dashboard"> Krypton Releases</a>

=======

## 2019-04-27 Build 968 - Bugfixes
* Fixed issue [#147](https://github.com/Wagnerp/Krypton-NET-5.470/issues/147), hint does not have a designer reset option
* Fixed issue [#146](https://github.com/Wagnerp/Krypton-NET-5.470/issues/146), PInvoke types should be structures and not classes
* Fixed issue [#155](https://github.com/Wagnerp/Krypton-NET-5.470/issues/155), new Shadow feature does not handle "Window bar flashing" as expected 
* Fixed issue [#156](https://github.com/Wagnerp/Krypton-NET-5.470/issues/156), new Shadow feature crashes for some variables entered
* Fixed issue [#161](https://github.com/Wagnerp/Krypton-NET-5.470/issues/161), "Admin" does not show up in forms or MessageBox's
* Fixed issues [#68](https://github.com/Wagnerp/Krypton-NET-5.470/issues/68), The look of krypton themes does not appear in windows 10 when I use the ribbon control & [#162](https://github.com/Wagnerp/Krypton-NET-5.470/issues/162), Adding a ribbon control to a blank form causes the form title bar to always be blue (system accent) when selected
* Build 968 (build date Saturday 27th April, 2019) is now available on NuGet

=======

## 2019-04-15 Build 901 - Drop Shadows
* New feature - now you can specify drop shadows on `KryptonForm` [#121](https://github.com/Wagnerp/Krypton-NET-5.470/issues/121). By design (or by accident :)), changing the shadow or form size values will display a offset of the shadow outcome.
* Patch for [#142](https://github.com/Wagnerp/Krypton-NET-5.470/issues/142) ribbon tab text not working, courtesy of Tape-Worm
* Build 901 (build date Monday 15th April, 2019) is now available on NuGet

=======

## 2019-04-14 Build 890 - Bugfixes
* Fixed issue [#127](https://github.com/Wagnerp/Krypton-NET-5.470/issues/127), flashing tooltips
* Fixed issue [#130](https://github.com/Wagnerp/Krypton-NET-5.470/issues/130)
* Completed issue [#137](https://github.com/Wagnerp/Krypton-NET-5.470/issues/137)
* Fixed issue [#132](https://github.com/Wagnerp/Krypton-NET-5.470/issues/132), missing `OnDropDownClosed()` event for `KryptonComboBox`
* Fixed issue [#129](https://github.com/Wagnerp/Krypton-NET-5.470/issues/129), hints appeared grey even though they were enabled
* Fixed issue [#124](https://github.com/Wagnerp/Krypton-NET-5.470/issues/124), tooltips would occasionally throw an exception
* Removed files relating to 2018 [#130](https://github.com/Wagnerp/Krypton-NET-5.470/issues/130)
* Minor alterations to `ThemeManager.cs`
* New installer [#133](https://github.com/Wagnerp/Krypton-NET-5.470/issues/133)
* Build 890 (build date Sunday 14th April, 2019) is now available on NuGet

=======

## 2019-04-10 Build 856 - Bugfixes and contributions
* Fixed issue [#104](https://github.com/Wagnerp/Krypton-NET-5.470/issues/104), designer usage exceptions
* Fixed issue [#116](https://github.com/Wagnerp/Krypton-NET-5.470/issues/116)
* `KryptonManager` now displays themes and names correctly
* General fixes to `ThemeManager.cs` & `RibbonThemeManager.cs`
* Implement `DrawItem()` event in KryptonComboBox
* Merge Muratoner: Make input box have a PasswordChar
* Merge Alexandr250: Adding a textual cue (Watermark) to KryptonTextBox
* Merge Thavarajan: Datagridview combobox updated for datasource integration
* More [#17](https://github.com/Wagnerp/Krypton-NET-5.470/issues/17) 
* Make the PopupPosition values follow serialisation reflection IDE Designer needs
* Update example program for AllowDecimals
* Introduced an IconSpec definition for all KryptonDataGridViewColumn types so that icons can be drawn in KryptonDataGridView column header cells
* Adding a Multiline String Editor much like in VS' property grid to the KryptonTextBox control.
* Add Multiline String Editor in KryptonDataGridViewTextBox cells for multiline text editing
* Make MultilineStringEditor resizable.
* Adding KryptonDataGridViewCustomColumn type for DataGridViews
* Adding new KryptonDataGridViewBinaryColumn type for displaying and viewing binary data in GridViews.
* Make Hex-Mode default mode and add a button for exporting the data to a file.
* Slide panels instantly like Visual Studio
* Ignore DBNull.Value as well in GetFormattedValue
* Make the checkbox look a little nicer
* contextMenuStrip gradient color
* Adding a PaletteBackStyle.PanelCustom2 and PaletteBackStyle.PanelCustom3 for more theming flexibility
	* Continue to add custom numbers for the others custom# styles as well !
* Adding HoveredSelectionChanged event to KryptonComboBox
* Make KryptonDataGridViewComboBox accept objects rather than strings only
* Prop up KryptonComboBox with optional tooltips for items
* Extend support for DataGridView icons to Text & data cells
* Build 856 (build date Wednesday 10th April, 2019) is now available on NuGet

=======

## 2019-03-18 Build 794
* Build 794 (build date Monday 18th March, 2019) is now available on NuGet

=======

## 2019-03-11 Build 791
* Fix for [#39](https://github.com/Wagnerp/Krypton-NET-5.450/issues/39)
* Fix for [#74](https://github.com/Wagnerp/Krypton-NET-5.450/issues/74)
* Fix for [#93](https://github.com/Wagnerp/Krypton-NET-5.450/issues/93)
* Fix for [#97](https://github.com/Wagnerp/Krypton-NET-5.450/issues/97)
* Now you are required to accept the license agreement when downloading new NuGet package versions
* Build 791 (build date Monday 11th March, 2019) is now available on NuGet

=======

## 2019-03-04 Build 770
* You can now use `Krypton Tooltips` on listboxes and treeviews [#90](https://github.com/Wagnerp/Krypton-NET-5.450/issues/90)
* You can now use `Krypton Tooltips` on every Krypton control [#85](https://github.com/Wagnerp/Krypton-NET-5.450/issues/85)
* `ThemeManager.cs` now makes it easier for developers to access the true theme names, without relying on nonsensical enumerations.
* Build 770 (build date Monday 4th March, 2019) is now available on NuGet

=======

## 2019-02-11 Build 720 - Fix for drop shadow while using the ribbon component
* Fix for [#5](https://github.com/Wagnerp/Krypton-NET-5.472/issues/5) courtesy of [richterAI](https://github.com/richterAl)
* Build 720 (build date Tuesday 12th February, 2019) is now available on NuGet

=======

## 2019-01-29 **`AccurateText.cs`** - Issue #75
* Bugfix for [#75](https://github.com/Wagnerp/Krypton-NET-5.471/issues/75) courtesy of [nickfinch71](https://github.com/nickfinch71)
* For more information about this issue on NT 6.0 systems, please read thread [#75](https://github.com/Wagnerp/Krypton-NET-5.471/issues/75)
* NuGet package build 717 (build date Tuesday 29th January, 2019) will be made available

=======

## 2019-01-03 Year Change
* Changed `2018` to `2019` in code
* Code parity with version `5.471`

=======

## 2018-09-25 Build 643
* Build 643 (build date Tuesday 25th September, 2018) is now available through the **releases** tab
* Allow the developer to override the `Ctrl+c to copy` text in the Caption
* The `Import()` and `Export()` methods will now use the native `KryptonMessageBox` instead of a system one
* Removed the phantom `KryptonPalette` component
* Now you can access the full `FilePath` of the loaded palette XML file
* New icon (not propagated through all the example applications yet)
* Fix KryptonForm does not respect Minimum Size set in designer #57
  * And sort out some spelling mistakes in the `VisualForm.cs`
* `SeparatorController.cs` & `DragObject` bug fix, #79
  * Fix for bug Issue, #79, courtesy of [James Simms](https://github.com/jwsimms)
* General bugfixes

=======

## 2018-07-10 Build 622
* Build 622 (build date Tuesday 10th July 2018) is now available through the `releases` tab.
* Includes least code from the 4.70 codebase.

=======

## 2018-06-15 Version 620
* Build 620 (build date Friday 15th June 2018) is now available through the `releases` tab.
* Signed the installer with certificate.
* Fixed references that blocked demo applications from launching.
* Start work on getting the system themes to display the extras. 
  * Not perfect but at least the "Chrome" displays the intended buttons and text(s).
* Removal of "not needed" casts.
* Remove the Designer dll (Project / code moved in Git)
* Place designers into actual dlls (Small size increase)
* Fix fallout from Designer dll removal from other projects
  * Fix build path output, and Demo Apps Ref path import and Output

=======

## 2018-05-01 Initial commit
* Adapted version of the Krypton-NET-4.71 repository
* Version change from `4.71` to `4.72`

## NOTE: This is a mirror of the Krypton-NET-4.71 repository, therefore it may take a day or two to update this repository with the .NET 4.7.2 framework. Thank you for your patience. 
