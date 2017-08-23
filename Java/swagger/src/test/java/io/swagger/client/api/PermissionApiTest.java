/*
 * Colectica Repository REST API
 * Colectica Repository REST API
 *
 * OpenAPI spec version: v1
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package io.swagger.client.api;

import io.swagger.client.ApiException;
import io.swagger.client.model.GetPermissionsRequest;
import io.swagger.client.model.RemovePermissionsRequest;
import io.swagger.client.model.RepositorySecurityContext;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for PermissionApi
 */
@Ignore
public class PermissionApiTest {

    private final PermissionApi api = new PermissionApi();

    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1PermissionDeletePostTest() throws ApiException {
        RemovePermissionsRequest request = null;
        api.apiV1PermissionDeletePost(request);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1PermissionGetPostTest() throws ApiException {
        GetPermissionsRequest request = null;
        RepositorySecurityContext response = api.apiV1PermissionGetPost(request);

        // TODO: test validations
    }
    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1PermissionPostTest() throws ApiException {
        RepositorySecurityContext request = null;
        api.apiV1PermissionPost(request);

        // TODO: test validations
    }
    
}
