// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IEventTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (EventTrigger))]
  [WebHostHidden]
  [Guid(3740858453, 2889, 16519, 177, 169, 184, 179, 132, 136, 247, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEventTrigger
  {
    RoutedEvent RoutedEvent { get; set; }

    TriggerActionCollection Actions { get; }
  }
}
