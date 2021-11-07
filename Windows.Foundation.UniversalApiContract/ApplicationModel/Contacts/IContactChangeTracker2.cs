// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactChangeTracker2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactChangeTracker))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2139803900, 37665, 19736, 156, 9, 215, 8, 198, 63, 205, 49)]
  internal interface IContactChangeTracker2
  {
    bool IsTracking { get; }
  }
}
