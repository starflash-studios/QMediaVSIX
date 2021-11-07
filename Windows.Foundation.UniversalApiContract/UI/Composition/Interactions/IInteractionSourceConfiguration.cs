// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionSourceConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Guid(2810398693, 43473, 19714, 152, 94, 185, 48, 205, 11, 157, 164)]
  [ExclusiveTo(typeof (InteractionSourceConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IInteractionSourceConfiguration
  {
    InteractionSourceRedirectionMode PositionXSourceMode { get; set; }

    InteractionSourceRedirectionMode PositionYSourceMode { get; set; }

    InteractionSourceRedirectionMode ScaleSourceMode { get; set; }
  }
}
