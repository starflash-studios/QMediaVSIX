// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.Preview.SoundLevelBroker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core.Preview
{
  /// <summary>Provides information about how the app's current sound level is affected by system policy.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ISoundLevelBrokerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class SoundLevelBroker
  {
    /// <summary>Gets the current sound level of the app.</summary>
    /// <returns>The current sound level of the app.</returns>
    public static extern SoundLevel SoundLevel { [MethodImpl] get; }

    /// <summary>Occurs when the system policy changes the sound level of the app.</summary>
    public static extern event EventHandler<object> SoundLevelChanged;
  }
}
