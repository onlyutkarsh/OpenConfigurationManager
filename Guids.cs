// Guids.cs
// MUST match guids.h
using System;

namespace Company.OpenConfigurationManager
{
    static class GuidList
    {
        public const string guidOpenConfigurationManagerPkgString = "dc9491fc-8a8d-4a97-8544-57de2d167fc0";
        public const string guidOpenConfigurationManagerCmdSetString = "c65f7201-6c6b-4358-a737-9759decbd772";

        public static readonly Guid guidOpenConfigurationManagerCmdSet = new Guid(guidOpenConfigurationManagerCmdSetString);
    };
}