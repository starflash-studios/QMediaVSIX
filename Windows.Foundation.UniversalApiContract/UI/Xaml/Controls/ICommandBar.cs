// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CommandBar))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2562474624, 19005, 19694, 189, 7, 34, 206, 148, 197, 175, 118)]
  [WebHostHidden]
  internal interface ICommandBar
  {
    IObservableVector<ICommandBarElement> PrimaryCommands { get; }

    IObservableVector<ICommandBarElement> SecondaryCommands { get; }
  }
}
