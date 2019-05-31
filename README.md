# GetFileModDate
Console app for getting the last modified date of a file.

In a command prompt, write GetFileModDate.exe [filepath] to get the last modified date of that file.

For example:
GetFileModDate.exe GetFileModDate.exe
*prints 2019-05-24 06:23:32*

Error handling:

On error, the username is printed so the user can easily recognize folder access rights issues.
If a file doesn't exist, the directory contents will be printed to allow the user to identify errors in path or file name.
