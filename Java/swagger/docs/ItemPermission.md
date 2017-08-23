
# ItemPermission

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**permissionId** | **Long** |  |  [optional]
**roleName** | **String** |  |  [optional]
**permission** | [**PermissionEnum**](#PermissionEnum) |  |  [optional]
**identifier** | [**UUID**](UUID.md) |  |  [optional]
**agencyId** | **String** |  |  [optional]
**version** | **Long** |  |  [optional]


<a name="PermissionEnum"></a>
## Enum: PermissionEnum
Name | Value
---- | -----
DENIEDREAD | &quot;DeniedRead&quot;
DENIEDWRITE | &quot;DeniedWrite&quot;
DENIED | &quot;Denied&quot;
EXCLUSIVEREAD | &quot;ExclusiveRead&quot;
EXCLUSIVEWRITE | &quot;ExclusiveWrite&quot;
EXCLUSIVE | &quot;Exclusive&quot;



