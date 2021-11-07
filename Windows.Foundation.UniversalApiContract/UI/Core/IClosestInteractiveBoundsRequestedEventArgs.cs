// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IClosestInteractiveBoundsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(880546263, 63224, 16611, 178, 159, 174, 80, 211, 232, 100, 134)]
  [ExclusiveTo(typeof (ClosestInteractiveBoundsRequestedEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IClosestInteractiveBoundsRequestedEventArgs
  {
    Point PointerPosition { get; }

    Rect SearchBounds { get; }

    Rect ClosestInteractiveBounds { get; set; }
  }
}
