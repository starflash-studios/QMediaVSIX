// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (FocusManager))]
  [Guid(893821366, 8383, 20487, 146, 157, 230, 211, 46, 22, 175, 228)]
  internal interface IFocusManagerStatics6
  {
    event EventHandler<FocusManagerGotFocusEventArgs> GotFocus;

    event EventHandler<FocusManagerLostFocusEventArgs> LostFocus;

    event EventHandler<GettingFocusEventArgs> GettingFocus;

    event EventHandler<LosingFocusEventArgs> LosingFocus;
  }
}
