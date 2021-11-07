// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBarFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4274859085, 61802, 22733, 138, 202, 219, 15, 4, 111, 37, 195)]
  [ExclusiveTo(typeof (CommandBarFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface ICommandBarFlyout
  {
    IObservableVector<ICommandBarElement> PrimaryCommands { get; }

    IObservableVector<ICommandBarElement> SecondaryCommands { get; }
  }
}
