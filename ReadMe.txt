# Configurator
Configurator is used to deploy app.config and web.config files that are ignored thanks to git ignore. If you need a way to distribute the config files among a team or to a Test server, this program is for you.

I use this project to update Visual Studio on our Test Server, so I can debug against the
same environment (same web.config, folder permissions and database).

This program makes a very big assumption, and that is the source and target folders
must be the same on each machine. If they are not, you will need to do
a search and replace in the ConfigOutput.txt file for each file entry.

Example:

My home pc has this path:

c:\Projects\MyClient\MyProject\MySolution.sln

And my client's dev server.

c:\Projects\MyProject\MySolution.sln

So I had to replace out the MyClient entry from the 

--

This program begins with you selecting two folders:

Solution Folder: This is the top level folder in your solution

Output Folder: The location on your local machine you want to deploy the config
files for transport.

Since each file has the same name (app.config or web.config), the parent folder
is created for each file if it doesn't exist. There are also a couple of exceptions coded in as
my clients project has web.config files in areas\client\views and areas\admin\views
plus the Views folder at the root of the project. These files have names created
such as AreasAdminViews, AreasClientViews or just Views for the one in the root.

Ignored Files:

There is a method in MainForm.cs (also the only form), called ShouldFileBeIgnored.
Config files such as nuget.config and packages.config, as well as .exe and .dll
plus any in bin or obj folders. I also have a couple of folders listed, such as Tools
and a couple of other for our project. It won't hurt to have these, just if you see
something strange it is probably the name of one of our projects I am not concerned
about at the moment.

You can always move it to where you want, or manually unpack the config files. *

* Unpacking means to read the ConfigOutput.txt file, which must be in the root
of the Output Folder.

SourceFile1
TargetFile1

SourceFile2
TargetFile2

SourceFile3
TargetFile3

...

Short cuts

If you know the two folders in advance, there are two settings in the app.config file
that can prepopulate the SolutionFolderControl and the OutputFolderControl *.

Nuget packages used:

DataJuggler.Win.Controls

* The SolutionFolderControl and OutputFolderControl, are both part of Nuget package
DataJuggler.Win.Controls and are a user control called LabelTextBoxBrowserControl. *

A LabelTextBoxBrowserControl consists of a Label, a TextBox, and a button to selet a file,
a folder or a Custom open. BrowseType Folder is used in this project.

There are two other controls that are used to display the results of the # of
web.config and # of app.config files found. These controls are LabelTextBoxControls. *

As the name implies, this consists of a Label and a TextBox.

These values are set during Packing only. Unpack could do it, it just doesn't. 
My weekend is running out of time, and I still have to fix the reason I started 
this project a few hours ago.

DataJuggler.UltimateHelper

This project is a dependency of DataJuggler.Win.Controls, and this is what I used to 
parse the text and for lots of other things.

--
Status of the project:

Pack has been tested and works.

Unpack has been tested and works.

Side Note: My work project's repo compiled once all the necessary config files were included, so I will call this project a success (unless you go by the number 
of clones, stars, mentions or other interactions. It worked for my purpose, fame and fortune is not what I desire (or I would be doing anything other than
giving away free code).

Let me know if this project is worth the price of free (please keep in my mind the free icon and free image in case you were leaning towards no).




