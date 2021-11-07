// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.RebootNeededEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Represents the method that handles the data passed by the MediaProtectionManager that requires a reboot.</summary>
  /// <param name="sender">Contains the MediaProtectionManager object that requires a reboot to occur.</param>
  [Guid(1692478021, 38715, 19002, 178, 96, 145, 137, 138, 73, 168, 44)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public delegate void RebootNeededEventHandler(MediaProtectionManager sender);
}
