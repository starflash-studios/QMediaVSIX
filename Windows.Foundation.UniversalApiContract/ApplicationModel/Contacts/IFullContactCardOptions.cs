// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IFullContactCardOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (FullContactCardOptions))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2269397868, 23801, 18051, 189, 202, 161, 253, 235, 248, 219, 206)]
  internal interface IFullContactCardOptions
  {
    ViewSizePreference DesiredRemainingView { get; set; }
  }
}
