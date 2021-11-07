// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAboutDataView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Used to view data about another app and the device it is running on.</summary>
  [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAllJoynAboutDataViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AllJoynAboutDataView : IAllJoynAboutDataView
  {
    /// <summary>The status returned by the GetDataBySessionPortAsync operation that created the AllJoynAboutDataView object.</summary>
    /// <returns>The status code.</returns>
    public extern int Status { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>This is a set of fields, where each other named AllJoynAboutDataView property is also accessible. For example, ModelNumber is Properties**["ModelNumber"]**. Additionally, this property can be used to get custom properties.</summary>
    /// <returns>A set of fields that provide access to AllJoynAboutDataView properties.</returns>
    public extern IMapView<string, object> Properties { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The version number for the implemented AllJoyn platform software.</summary>
    /// <returns>Current version number.</returns>
    public extern string AJSoftwareVersion { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A globally unique identifier associated with the app.</summary>
    /// <returns>A GUID representing the globally unique identifier.</returns>
    public extern Guid AppId { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The date of manufacture.</summary>
    /// <returns>A date value in the **YYYY-MM-DD** format.</returns>
    public extern IReference<global::Windows.Foundation.DateTime> DateOfManufacture { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The default language of the app.</summary>
    /// <returns>The default language.</returns>
    public extern Language DefaultLanguage { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The device ID used during advertising.</summary>
    /// <returns>The device ID.</returns>
    public extern string DeviceId { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The current version of the hardware that the app is running on. This field is optional, presenting as an empty string if not set.</summary>
    /// <returns>The hardware version number.</returns>
    public extern string HardwareVersion { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The model number of the device running the app.</summary>
    /// <returns>The model number.</returns>
    public extern string ModelNumber { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The version number of the app.</summary>
    /// <returns>The version number.</returns>
    public extern string SoftwareVersion { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A list of languages supported by the app and will always include the DefaultLanguage.</summary>
    /// <returns>A list of Language objects.</returns>
    public extern IVectorView<Language> SupportedLanguages { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A URL to the manufacturer or developer support portal.</summary>
    /// <returns>The support URL.</returns>
    public extern global::Windows.Foundation.Uri SupportUrl { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The name of the app.</summary>
    /// <returns>The app name.</returns>
    public extern string AppName { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>An app description provided by the manufacturer.</summary>
    /// <returns>The app description.</returns>
    public extern string Description { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Name of the device.</summary>
    /// <returns>The device name.</returns>
    public extern string DeviceName { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The name of the manufacturer.</summary>
    /// <returns>The manufacturer name.</returns>
    public extern string Manufacturer { [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the About data for a session.</summary>
    /// <param name="uniqueName">The unique name.</param>
    /// <param name="busAttachment">The bus attachment supporting the session.</param>
    /// <param name="sessionPort">The port used to connect to the session.</param>
    /// <returns>An object containing About data for the session.</returns>
    [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [RemoteAsync]
    [Overload("GetDataBySessionPortAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort);

    /// <summary>Gets the About data for a session in a particular language.</summary>
    /// <param name="uniqueName">The unique name.</param>
    /// <param name="busAttachment">The bus attachment supporting the session.</param>
    /// <param name="sessionPort">The port used to connect to the session.</param>
    /// <param name="language">The language to return the descriptive data in.</param>
    /// <returns>An object containing About data for the session in the set language.</returns>
    [Overload("GetDataBySessionPortWithLanguageAsync")]
    [RemoteAsync]
    [Deprecated("AllJoynAboutDataView has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynAboutDataView> GetDataBySessionPortAsync(
      string uniqueName,
      AllJoynBusAttachment busAttachment,
      ushort sessionPort,
      Language language);
  }
}
