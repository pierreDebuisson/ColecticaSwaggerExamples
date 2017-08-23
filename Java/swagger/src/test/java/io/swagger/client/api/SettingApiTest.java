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
import io.swagger.client.model.RepositorySetting;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for SettingApi
 */
@Ignore
public class SettingApiTest {

    private final SettingApi api = new SettingApi();

    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1SettingBySettingDeleteTest() throws ApiException {
        String setting = null;
        api.apiV1SettingBySettingDelete(setting);

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
    public void apiV1SettingBySettingGetTest() throws ApiException {
        String setting = null;
        RepositorySetting response = api.apiV1SettingBySettingGet(setting);

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
    public void apiV1SettingGetTest() throws ApiException {
        List<RepositorySetting> response = api.apiV1SettingGet();

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
    public void apiV1SettingPostTest() throws ApiException {
        RepositorySetting request = null;
        api.apiV1SettingPost(request);

        // TODO: test validations
    }
    
}
