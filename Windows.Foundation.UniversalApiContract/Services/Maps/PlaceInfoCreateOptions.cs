// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.PlaceInfoCreateOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents the information about a map location that your app can show in a light-dismissible window within your app.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class PlaceInfoCreateOptions : IPlaceInfoCreateOptions
  {
    /// <summary>Creates a PlaceInfoCreateOptions instance.</summary>
    [MethodImpl]
    public extern PlaceInfoCreateOptions();

    /// <summary>Gets the display name associated with the PlaceInfoCreateOptions.</summary>
    /// <returns>The display name associated with the PlaceInfoCreateOptions.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the address associated with the PlaceInfoCreateOptions.</summary>
    /// <returns>The address associated with the PlaceInfoCreateOptions.</returns>
    public extern string DisplayAddress { [MethodImpl] set; [MethodImpl] get; }
  }
}
