// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBoxPasswordChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(338614818, 13650, 19128, 129, 166, 164, 134, 32, 238, 156, 83)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (PasswordBoxPasswordChangingEventArgs))]
  internal interface IPasswordBoxPasswordChangingEventArgs
  {
    bool IsContentChanging { get; }
  }
}
