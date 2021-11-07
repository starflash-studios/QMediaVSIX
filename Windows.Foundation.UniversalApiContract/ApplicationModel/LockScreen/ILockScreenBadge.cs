// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockScreenBadge
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.LockScreen
{
  [Guid(3914401241, 11263, 19888, 155, 79, 56, 36, 119, 139, 156, 154)]
  [ExclusiveTo(typeof (LockScreenBadge))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILockScreenBadge
  {
    IRandomAccessStream Logo { get; }

    IRandomAccessStream Glyph { get; }

    IReference<uint> Number { get; }

    string AutomationName { get; }

    void LaunchApp();
  }
}
