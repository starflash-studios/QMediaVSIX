// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IVisualElementsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(2070923650, 14861, 20174, 175, 150, 205, 23, 225, 176, 11, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VisualElementsRequestedEventArgs))]
  internal interface IVisualElementsRequestedEventArgs
  {
    VisualElementsRequest Request { get; }
  }
}
