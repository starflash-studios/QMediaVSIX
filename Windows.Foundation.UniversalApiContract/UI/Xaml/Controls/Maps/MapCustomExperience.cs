// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapCustomExperience
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a custom experience for the MapControl.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IMapCustomExperienceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class MapCustomExperience : DependencyObject, IMapCustomExperience
  {
    /// <summary>This API is for internal use only. Use StreetsideExperience to create a street-level views.</summary>
    [MethodImpl]
    public extern MapCustomExperience();
  }
}
