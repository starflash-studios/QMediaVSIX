// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionPropertySet
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(3386298882, 24423, 17491, 145, 23, 158, 173, 212, 48, 211, 194)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionPropertySet))]
  internal interface ICompositionPropertySet
  {
    void InsertColor(string propertyName, Color value);

    void InsertMatrix3x2(string propertyName, Matrix3x2 value);

    void InsertMatrix4x4(string propertyName, Matrix4x4 value);

    void InsertQuaternion(string propertyName, Quaternion value);

    void InsertScalar(string propertyName, float value);

    void InsertVector2(string propertyName, Vector2 value);

    void InsertVector3(string propertyName, Vector3 value);

    void InsertVector4(string propertyName, Vector4 value);

    CompositionGetValueStatus TryGetColor(
      string propertyName,
      out Color value);

    CompositionGetValueStatus TryGetMatrix3x2(
      string propertyName,
      out Matrix3x2 value);

    CompositionGetValueStatus TryGetMatrix4x4(
      string propertyName,
      out Matrix4x4 value);

    CompositionGetValueStatus TryGetQuaternion(
      string propertyName,
      out Quaternion value);

    CompositionGetValueStatus TryGetScalar(
      string propertyName,
      out float value);

    CompositionGetValueStatus TryGetVector2(
      string propertyName,
      out Vector2 value);

    CompositionGetValueStatus TryGetVector3(
      string propertyName,
      out Vector3 value);

    CompositionGetValueStatus TryGetVector4(
      string propertyName,
      out Vector4 value);
  }
}
