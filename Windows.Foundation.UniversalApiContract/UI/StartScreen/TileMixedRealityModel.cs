// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.TileMixedRealityModel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.StartScreen
{
  /// <summary>Represents a 3D model asset for use as an app launcher in the Windows Mixed Reality home environment.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class TileMixedRealityModel : ITileMixedRealityModel, ITileMixedRealityModel2
  {
    /// <summary>Gets or sets the path to the mixed reality model.</summary>
    /// <returns>The location of the mixed reality model file within the app package or local storage. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Uri { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the bounding box that defines the size of the model in the Windows Mixed Reality home in meters.</summary>
    /// <returns>The bounding box.  If this value is null, the system will determine the bounding box when it loads the model.  The default value is null.</returns>
    public extern IReference<SpatialBoundingBox> BoundingBox { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets what the system does when the user selects this tile.</summary>
    /// <returns>A value that specifies how the system behaviors when the user selects this tile. The default behavior is to launch the associated app.</returns>
    public extern TileMixedRealityModelActivationBehavior ActivationBehavior { [MethodImpl] set; [MethodImpl] get; }
  }
}
