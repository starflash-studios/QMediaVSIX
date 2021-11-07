// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapCustomExperienceChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Provides data for the CustomExperienceChanged event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class MapCustomExperienceChangedEventArgs : IMapCustomExperienceChangedEventArgs
  {
    /// <summary>Initializes a new instance of the MapCustomExperienceChangedEventArgs class.</summary>
    [MethodImpl]
    public extern MapCustomExperienceChangedEventArgs();
  }
}
