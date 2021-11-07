// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.FirstSignInSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  /// <summary>Represents a collection of settings that a user can opt-in to during the first run experience.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IFirstSignInSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class FirstSignInSettings : 
    IFirstSignInSettings,
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
    [MethodImpl]
    public extern object Lookup(string key);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool HasKey(string key);

    [MethodImpl]
    public extern void Split(
      out IMapView<string, object> first,
      out IMapView<string, object> second);

    [MethodImpl]
    public extern IIterator<IKeyValuePair<string, object>> First();

    /// <summary>Gets the default instance of the settings.</summary>
    /// <returns>The default instance of the settings.</returns>
    [MethodImpl]
    public static extern FirstSignInSettings GetDefault();
  }
}
