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
import io.swagger.client.model.RepositoryInfo;
import io.swagger.client.model.RepositoryStatistics;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for RepositoryApi
 */
@Ignore
public class RepositoryApiTest {

    private final RepositoryApi api = new RepositoryApi();

    
    /**
     * 
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void apiV1RepositoryInfoGetTest() throws ApiException {
        RepositoryInfo response = api.apiV1RepositoryInfoGet();

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
    public void apiV1RepositoryStatisticsGetTest() throws ApiException {
        RepositoryStatistics response = api.apiV1RepositoryStatisticsGet();

        // TODO: test validations
    }
    
}
