// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.ManeuverWarning
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents a potential issue along a route leg.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  public sealed class ManeuverWarning : IManeuverWarning
  {
    /// <summary>Gets the type of potential issue along a route leg.</summary>
    /// <returns>The type of potential issue along a route leg.</returns>
    public extern ManeuverWarningKind Kind { [MethodImpl] get; }

    /// <summary>Gets the severity of a potential issue along a route leg.</summary>
    /// <returns>The severity of a potential issue along a route leg.</returns>
    public extern ManeuverWarningSeverity Severity { [MethodImpl] get; }
  }
}
