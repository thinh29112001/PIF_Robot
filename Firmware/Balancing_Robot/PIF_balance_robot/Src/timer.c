/*
 * timer.c
 *
 *  Created on: Sep 16, 2020
 *      Author: Lenovo
 */
#include <stdio.h>
#include <stdint.h>
#include <ctype.h>
#include <time.h>

#define MAX_THREAD 10

typedef void (*thread_func_t)(char*);
typedef int thread_id_t;
typedef enum {
    THREAD_REPEAT,          // Function only run one time
    THREAD_SINGLESHOT       // Function run periodically
}thread_type_t;

typedef struct {
    thread_func_t thread_func;  // Pointer to function
    int period;                 // Period of function
    int cnt;                    // Internal counter
    thread_type_t type;         // Type of thread
    char* ctx;                  // Give this to function when run it
}thread_t;

thread_t m_thread[MAX_THREAD];

thread_id_t register_thread(thread_func_t thread_func,int period_ms, thread_type_t type, char* context) {
    for (int i = 0; i < MAX_THREAD; i++) {
        if (m_thread[i].thread_func == NULL) // Check if is there any empty slot
        {
            m_thread[i].thread_func = thread_func;
            m_thread[i].period = period_ms;
            m_thread[i].cnt = period_ms;
            m_thread[i].type = type;
            m_thread[i].ctx = context;
            return i;
        }
    }
    return -1; // if there is no slot remain, return invalid id
}

_Bool unregister_thread(thread_id_t proc_id) {
    if (m_thread[proc_id].thread_func != NULL) {
        m_thread[proc_id].thread_func = NULL;
        return 1;
    }
    else {
        return 0;
    }
}

void one_ms_timer_interrupt() {
    for (int i = 0; i < MAX_THREAD; i++) {
        if (m_thread[i].thread_func != NULL) {
            m_thread[i].cnt--;                                  // Reduce internal counter
            if (m_thread[i].cnt == 0) {                         // Check if timeout
                m_thread[i].thread_func(m_thread[i].ctx);       // Run fucntion with context
                if (m_thread[i].type == THREAD_REPEAT) {        // Check thread type
                    m_thread[i].cnt = m_thread[i].period;       // Reset counter
                }
                else if(m_thread[i].type == THREAD_SINGLESHOT)
                {
                    m_thread[i].thread_func = NULL;             // Unregister thread
                }
            }
        }
    }
}

