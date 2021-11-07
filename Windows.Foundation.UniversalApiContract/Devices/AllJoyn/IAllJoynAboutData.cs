// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAboutData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynAboutData))]
  [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3853106944, 8098, 18489, 147, 239, 249, 223, 64, 72, 144, 247)]
  internal interface IAllJoynAboutData
  {
    bool IsEnabled { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    string DefaultAppName { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    IMap<string, string> AppNames { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    IReference<global::Windows.Foundation.DateTime> DateOfManufacture { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    string DefaultDescription { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    IMap<string, string> Descriptions { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string DefaultManufacturer { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    IMap<string, string> Manufacturers { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string ModelNumber { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    string SoftwareVersion { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    global::Windows.Foundation.Uri SupportUrl { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }

    Guid AppId { [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("AllJoynAboutData has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] set; }
  }
}
