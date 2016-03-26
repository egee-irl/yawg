# Yet Another Wine Gui

Yet Another Wine GUI (Yawg) is a simple prototype GTK# application. It's purpose was to allow access to Wine functions and applications without having to use the CLI.

Yawg is written in Mono and GTK **2** using Stetic, a Windows Forms-like GUI builder built into MonoDevelop.

## Uses
The project was a prototype as much as it was a learning exercise for me to familiarize myself with Mono tools on Linux but also GUI development and GUI builders. As such, this project has reach its end of life and will not be updated.

## Compatibility

Yawg simply uses the built-in Wine applications and calls them through Mono processes. Unless Wine breaks compatibility with itself, the code in WineFunctions.cs will probably always be valid.

Yawg uses GTK Sharp 2.x (not 3.x) but there shouldn't be any compatibility concerns there.

## Dependencies

The following dlls are used to build this project:

* atk-sharp
* gdk-sharp
* glade-sharp
* glib-sharp
* gtk-sharp
* Mono.Posix
* pango-sharp
