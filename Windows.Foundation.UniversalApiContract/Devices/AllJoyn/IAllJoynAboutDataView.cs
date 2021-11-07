// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynAboutDataView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AllJoynAboutDataView))]
  [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [Guid(1747128607, 25106, 18740, 156, 72, 225, 156, 164, 152, 66, 136)]
  internal interface IAllJoynAboutDataView
  {
    int Status { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    IMapView<string, object> Properties { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string AJSoftwareVersion { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    Guid AppId { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    IReference<global::Windows.Foundation.DateTime> DateOfManufacture { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    Language DefaultLanguage { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceId { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string HardwareVersion { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string ModelNumber { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string SoftwareVersion { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    IVectorView<Language> SupportedLanguages { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    global::Windows.Foundation.Uri SupportUrl { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string AppName { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string Description { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string DeviceName { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string Manufacturer { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
