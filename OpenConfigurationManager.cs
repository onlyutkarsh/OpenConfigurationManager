namespace Company.OpenConfigurationManager
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidOpenConfigurationManagerPkgString = "dc9491fc-8a8d-4a97-8544-57de2d167fc0";
        public const string guidOpenConfigurationManagerCmdSetString = "c65f7201-6c6b-4358-a737-9759decbd772";
        public const string guidImagesString = "41e568c9-9cdb-48a4-9a78-b29284b4c6d6";
        public static Guid guidOpenConfigurationManagerPkg = new Guid(guidOpenConfigurationManagerPkgString);
        public static Guid guidOpenConfigurationManagerCmdSet = new Guid(guidOpenConfigurationManagerCmdSetString);
        public static Guid guidImages = new Guid(guidImagesString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int MyMenuGroup = 0x1020;
        public const int cmdidMyCommand = 0x0100;
        public const int bmpPic1 = 0x0001;
        public const int bmpPic2 = 0x0002;
        public const int bmpPicSearch = 0x0003;
        public const int bmpPicX = 0x0004;
        public const int bmpPicArrows = 0x0005;
        public const int bmpPicStrikethrough = 0x0006;
    }
}
