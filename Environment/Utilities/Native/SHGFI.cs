namespace System.Drawing.Icons.Native;

/// <inheritdoc cref="IconsExtractor"/>
[Flags]
internal enum SHGFI : uint {
  Icon = 256, // 0x00000100
  DisplayName = 512, // 0x00000200
  TypeName = 1024, // 0x00000400
  Attributes = 2048, // 0x00000800
  IconLocation = 4096, // 0x00001000
  ExeType = 8192, // 0x00002000
  SysIconIndex = 16384, // 0x00004000
  LinkOverlay = 32768, // 0x00008000
  Selected = 65536, // 0x00010000
  Attr_Specified = 131072, // 0x00020000
  LargeIcon = 0,
  SmallIcon = 1,
  OpenIcon = 2,
  ShellIconSize = 4,
  PIDL = 8,
  UseFileAttributes = 16, // 0x00000010
  AddOverlays = 32, // 0x00000020
  OverlayIndex = 64, // 0x00000040
}