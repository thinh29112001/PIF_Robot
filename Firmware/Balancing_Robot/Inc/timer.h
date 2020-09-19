/*
 * timer.h
 *
 *  Created on: Sep 16, 2020
 *      Author: Lenovo
 */

#ifndef TIMER_H_
#define TIMER_H_

#define MAX_THREAD 10

typedef void (*thread_func_t)(char*);
typedef int thread_id_t;
typedef enum {
    THREAD_REPEAT,          // Function only run one time
    THEEAD_SINGLESHOT       // Function run periodically
}thread_type_t;

typedef struct {
    thread_func_t thread_func;  // Pointer to function
    int period;                 // Period of function
    int cnt;                    // Internal counter
    thread_type_t type;         // Type of thread
    char* ctx;                  // Give this to function when run it
}thread_t;

void one_ms_timer_interrupt();

#endif /* TIMER_H_ */
