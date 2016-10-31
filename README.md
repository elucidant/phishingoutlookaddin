# PhishingOutlookAddIn
##Phishing Outlook AddIn##

Simplifies the Microsoft Outlook 2016 user experience for reporting a Phish by providing a Phish reporting button on the Outlook client. This button would facilitate the steps to attach the suspected Phish email and forward to the appropriate IT Phish email management group, and deleting the suspected phish email from the user's mail folder.

###Dependencies###
####Packages####

#####LOG4NET (2.0.5)#####
The Apache log4net library is a tool to help the programmer output log statements to a variety of output targets. log4net is a port of the excellent Apache log4j framework to the Microsoft .NET runtime. We have kept the framework similar in spirit to the original log4j while taking advantage of new features in the .NET runtime.  This package is required to be able to compile and build the Phishing Outlook AddIn.

####Redistribution Packages####
#####Microsoft .NET 4.52#####
The Phishing Outlook AddIn requires the Microsoft .NET Framework 4.52 Full library to be installed on the target system.  The AddIn installer will need to include a redistribution package to install this component upon installation.

#####Microsoft VSTO 2010 Runtime#####
The Phishing Outlook AddIn requires the Microsoft VSTO 2010 Runtime for Office library installed.  This is required to run Microsoft Office based solutions build using Microsoft Visual Studio 2010, 2012, 2013, and 2015.  To run VSTO Add-ins where were created by using the Office developer tools in Visual Studio, target computers must have the Visual Studio Tools for Office runtime installed.  The runtime library includes unmanaged components and a set of managed assemblies. The unmanaged components load the VSTO Add-in assembly.  The managed assemblies provide the object model that your VSTO Add-in code uses to automate and extend the host application.

### AddIn Resiliency ###
A major complaint surrounding Outlook and AddIns is that Outlook disables an AddIn if it thinks the COM AddIn causes Outlook to load too slowly.  A way to get around this is to set a registry value to force Outlook to always load a specific AddIn at startup. Outlook will disable an AddIn that it believes it causes Outlook to crash, but won’t disable an AddIn because it loads too slow.  The Resiliency Registry key value that needs to be added is in the following path in the User's Registry Hive (HKEY_CURRENT_USER).  Here is the registry key value and it's value for Outlook 2016:

|:-------------------:|:--------------------------------------------------------------------------------------------------------|
| **Key Value**       | HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Outlook\Resiliency\DoNotDisableAddinList\PhishingAddIn |
| **Key Value Type**  | REG_DWORD                                                                                               |
| **Key Value**       | 0x00000001                                                                                              |

The Resiliency Registry Key Value can be set in the following manner:

1. After AddIn installation, if Outlook comes up with the Phishing Outlook AddIn disabled, one can navigate to Outlook's File/Manage COM Add-ins.  Locate the "Phishing Outlook Add-In", and click the "Always enable this add-in" button.  This will generate the Resiliency Registry Key Value in the User's Registry Hive (HKEY_CURRENT_USER).

2. Prior to installing the AddIn, the Office Administrator can deploy a GPO to have the Resiliency Registry Key Value created on the User's Registry Hive (HKEY_CURRENT_USER) upon log on to his/her machine.  After that is pushed, the AddIn can be installed on the User's machine.  

We recommend option #2 above since it mitigates the need for User interjection when getting the AddIn deployed.

##License##
GNU GENERAL PUBLIC LICENSE
Version 3, 29 June 2007

Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>

Everyone is permitted to copy and distribute verbatim copies
of this license document, but changing it is not allowed.

The GNU General Public License is a free, copyleft license for
software and other kinds of works.

The licenses for most software and other practical works are designed
to take away your freedom to share and change the works.  By contrast,
the GNU General Public License is intended to guarantee your freedom to
share and change all versions of a program--to make sure it remains free
software for all its users.  We, the Free Software Foundation, use the
GNU General Public License for most of our software; it applies also to
any other work released this way by its authors.  You can apply it to
your programs, too.

When we speak of free software, we are referring to freedom, not
price.  Our General Public Licenses are designed to make sure that you
have the freedom to distribute copies of free software (and charge for
them if you wish), that you receive source code or can get it if you
want it, that you can change the software or use pieces of it in new
free programs, and that you know you can do these things.

To protect your rights, we need to prevent others from denying you
these rights or asking you to surrender the rights.  Therefore, you have
certain responsibilities if you distribute copies of the software, or if
you modify it: responsibilities to respect the freedom of others.

For example, if you distribute copies of such a program, whether
gratis or for a fee, you must pass on to the recipients the same
freedoms that you received.  You must make sure that they, too, receive
or can get the source code.  And you must show them these terms so they
know their rights.

Developers that use the GNU GPL protect your rights with two steps:
(1) assert copyright on the software, and (2) offer you this License
giving you legal permission to copy, distribute and/or modify it.

For the developers' and authors' protection, the GPL clearly explains
that there is no warranty for this free software.  For both users' and
authors' sake, the GPL requires that modified versions be marked as
changed, so that their problems will not be attributed erroneously to
authors of previous versions.

Some devices are designed to deny users access to install or run
modified versions of the software inside them, although the manufacturer
can do so.  This is fundamentally incompatible with the aim of
protecting users' freedom to change the software.  The systematic
pattern of such abuse occurs in the area of products for individuals to
use, which is precisely where it is most unacceptable.  Therefore, we
have designed this version of the GPL to prohibit the practice for those
products.  If such problems arise substantially in other domains, we
stand ready to extend this provision to those domains in future versions
of the GPL, as needed to protect the freedom of users.

Finally, every program is threatened constantly by software patents.
States should not allow patents to restrict development and use of
software on general-purpose computers, but in those that do, we wish to
avoid the special danger that patents applied to a free program could
make it effectively proprietary.  To prevent this, the GPL assures that
patents cannot be used to render the program non-free.

