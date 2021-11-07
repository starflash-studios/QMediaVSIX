// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSource3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualInteractionSource))]
  [Guid(3644976938, 3420, 16471, 146, 215, 201, 113, 21, 51, 32, 79)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IVisualInteractionSource3
  {
    InteractionSourceConfiguration PointerWheelConfig { get; }
  }
}
