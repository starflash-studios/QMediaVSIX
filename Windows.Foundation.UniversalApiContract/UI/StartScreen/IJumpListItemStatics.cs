// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpListItemStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (JumpListItem))]
  [Guid(4055876840, 51114, 18891, 141, 222, 236, 252, 205, 122, 215, 228)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IJumpListItemStatics
  {
    JumpListItem CreateWithArguments(string arguments, string displayName);

    JumpListItem CreateSeparator();
  }
}
