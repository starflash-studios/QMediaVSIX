// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppDisplayInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel
{
  /// <summary>Provides an application's name, description, and logo</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppDisplayInfo : IAppDisplayInfo
  {
    /// <summary>Gets the application's display name.</summary>
    /// <returns>The display name of the application as defined in the package manifest (Package.appxmanifest).</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the application's description.</summary>
    /// <returns>The description of the application as defined in the package manifest (Package.appxmanifest).</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Get the application's logo.</summary>
    /// <param name="size">The size of the rectangle in which the logo must fit.</param>
    /// <returns>The largest logo in your Package.appxmanifest file that will fit in the specified *Size*.</returns>
    [MethodImpl]
    public extern RandomAccessStreamReference GetLogo(Size size);
  }
}
